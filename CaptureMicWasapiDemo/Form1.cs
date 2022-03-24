using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace CaptureMicWasapiDemo
{
    public partial class Form1 : Form
    {
        private WasapiCapture capture;
        private WasapiOut outputDevice;

        private BufferedWaveProvider waveProvider;
        public Form1()
        {
            InitializeComponent();
            LoadDevices();

        }

        private void LoadDevices()
        {
            var deviceEnumerator = new MMDeviceEnumerator();
            var devices = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToList();

            RecordingDeviceComboBox.DataSource = devices;
            RecordingDeviceComboBox.DisplayMember = "CaptureDevice";

            var renderDevices = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToList();
            PlaybackDeviceComboBox.DataSource = renderDevices;
            PlaybackDeviceComboBox.DisplayMember = "RenderDevice";
        }


        private void RecordButton_Click(object sender, EventArgs e)
        {
            RecordButton.Enabled = false;
            StopButton.Enabled = true;

            var recordingDevice = (MMDevice)RecordingDeviceComboBox.SelectedItem;
            capture = new WasapiCapture(recordingDevice);


            var playbackDevice = (MMDevice)PlaybackDeviceComboBox.SelectedItem;


            outputDevice = new WasapiOut(playbackDevice, AudioClientShareMode.Shared, false, 20);

            waveProvider = new BufferedWaveProvider(capture.WaveFormat);
            waveProvider.DiscardOnBufferOverflow = true;


            outputDevice.Init(waveProvider);
            outputDevice.Play();

            capture.DataAvailable += OnDataAvailable;

            capture.StartRecording();
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            RecordButton.Enabled = true;
            StopButton.Enabled = false;
            capture.StopRecording();
            capture?.Dispose();
            outputDevice?.Dispose();
        }

        void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            waveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }
      
    }
}