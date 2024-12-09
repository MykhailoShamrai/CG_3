using GK_3.Converters;
using System.Drawing.Imaging;
using System.Net.Http.Headers;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GK_3
{
    public partial class MainForm : Form
    {
        private ImageCreator _creator = new ImageCreator();
        private Bitmap? _selectedImage;
        private Bitmap? _firstImage;
        private Bitmap? _secondImage;
        private Bitmap? _thirdImage;
        private List<ColorProfile> _colorProfiles = new List<ColorProfile>();
        private List<Iluminant> _illuminants = new List<Iluminant>();
        private List<IConverter> _converters = new List<IConverter>();
        public MainForm()
        {
            InitializeComponent();
            _selectedImage = ImageFromFile("1669101071_1-pibig-info-p-alukarda-oboi-1.jpg");

            pictureBoxSelectedImage.Image = _selectedImage;

            // Adding to lists of profiles and Illuminants
            foreach (ColorProfile.ColorProfileType type in Enum.GetValues(typeof(ColorProfile.ColorProfileType)))
            {
                _colorProfiles.Add(ColorProfile.GenerateColorProfile(type));
                comboBoxColorProfile.Items.Add(type.ToString());
            }
            foreach (Iluminant.IlluminantPredefinedType type in Enum.GetValues(typeof(Iluminant.IlluminantPredefinedType)))
            {
                _illuminants.Add(Iluminant.GenerateIlluminant(type));
                comboBoxIlluminant.Items.Add(type.ToString());
            }

            comboBoxMode.Items.Add("YCbCr");
            comboBoxMode.Items.Add("HSV");
            comboBoxMode.Items.Add("Lab");
            comboBoxMode.SelectedIndex = 0;
            _converters.Add(new YCbCrConverter());
            _converters.Add(new HSVConverter());
            _converters.Add(new LabConverter());

            comboBoxColorProfile.SelectedIndex = 0;
            comboBoxIlluminant.SelectedIndex = 0;


            _firstImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);
            _secondImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);
            _thirdImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);
            pictureBoxFirst.Image = _firstImage;
            pictureBoxSecond.Image = _secondImage;
            pictureBoxThird.Image = _thirdImage;


            comboBoxColorProfile.SelectedIndex = 0;
            comboBoxIlluminant.SelectedIndex = 0;

            CheckIfShowParametersColorProfileOnTheScreen();
            CheckIfShowParametersIlluminantOnTheScreen();
            ShowNumerics();
            buttonSaveOutput.Enabled = false;
        }

        private void ShowNumerics()
        {
            ColorProfile profile = _colorProfiles[comboBoxColorProfile.SelectedIndex];
            Iluminant iluminant = _illuminants[comboBoxIlluminant.SelectedIndex];
            numericUpDownXR.Value = (decimal)profile.XRed;
            numericUpDownYR.Value = (decimal)profile.YRed;
            numericUpDownXG.Value = (decimal)profile.XGreen;
            numericUpDownYG.Value = (decimal)profile.YGreen;
            numericUpDownXB.Value = (decimal)profile.XBlue;
            numericUpDownYB.Value = (decimal)profile.YBlue;
            numericUpDownGamma.Value = (decimal)profile.Gamma;
            numericUpDownXW.Value = (decimal)iluminant.XWhite;
            numericUpDownYW.Value = (decimal)iluminant.YWhite;
        }

        private void CheckIfShowParametersColorProfileOnTheScreen()
        {
            bool allow = _colorProfiles[comboBoxColorProfile.SelectedIndex].Type == ColorProfile.ColorProfileType.Custom;
            comboBoxIlluminant.Enabled = allow;
            numericUpDownXR.Enabled = allow;
            numericUpDownYR.Enabled = allow;
            numericUpDownXG.Enabled = allow;
            numericUpDownYG.Enabled = allow;
            numericUpDownXB.Enabled = allow;
            numericUpDownYB.Enabled = allow;
            numericUpDownGamma.Enabled = allow;
        }

        private void CheckIfShowParametersIlluminantOnTheScreen()
        {
            bool allow = _illuminants[comboBoxIlluminant.SelectedIndex].Type == Iluminant.IlluminantPredefinedType.Custom;
            numericUpDownXW.Enabled = allow;
            numericUpDownYW.Enabled = allow;
        }

        public static Bitmap? ImageFromFile(string fileName)
        {
            fileName = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
            {
                return new Bitmap(fileName);
            }
            return null;
        }

        public static void ShowDialogForImage(ref Bitmap image)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.InitialDirectory = Directory.GetCurrentDirectory();
            dialog.Filter = "Image files (*.png, *.jpg)|*.png;*.jpg";
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var tmp = ImageFromFile(dialog.FileName);
                image = tmp is null ? image : tmp;
            }
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMode.SelectedItem)
            {
                case "YCbCr":
                    labelFirst.Text = "Y";
                    labelSecond.Text = "Cb";
                    labelThird.Text = "Cr";
                    break;
                case "HSV":
                    labelFirst.Text = "H";
                    labelSecond.Text = "S";
                    labelThird.Text = "V";
                    break;
                case "Lab":
                    labelFirst.Text = "L";
                    labelSecond.Text = "a";
                    labelThird.Text = "b";
                    break;
            }
        }

        private void comboBoxColorProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColorProfile.SelectedIndex < 0)
            {
                comboBoxColorProfile.SelectedIndex = 0;
            }
            if (comboBoxIlluminant.SelectedIndex < 0)
            {
                comboBoxIlluminant.SelectedIndex = 0;
            }
            comboBoxIlluminant.SelectedIndex = 0;
            CheckIfShowParametersColorProfileOnTheScreen();
            CheckIfShowParametersIlluminantOnTheScreen();
            ShowNumerics();
        }

        private void comboBoxIlluminant_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIfShowParametersIlluminantOnTheScreen();
            ShowNumerics();
        }

        private void buttonSeparateChannels_Click(object sender, EventArgs e)
        {
            var res = _converters[comboBoxMode.SelectedIndex].Convert(_selectedImage!,
                _colorProfiles[comboBoxColorProfile.SelectedIndex], _illuminants[comboBoxIlluminant.SelectedIndex]);
            _converters[comboBoxMode.SelectedIndex].DrawToBitmap(_firstImage!, _secondImage!, _thirdImage!, res);
            pictureBoxFirst.Invalidate();
            pictureBoxSecond.Invalidate();
            pictureBoxThird.Invalidate();
            buttonSaveOutput.Enabled = true;
        }

        private void numericUpDownXR_ValueChanged(object sender, EventArgs e)
        {
            _colorProfiles[comboBoxColorProfile.SelectedIndex].XRed = (float)numericUpDownXR.Value;
        }

        private void numericUpDownYR_ValueChanged(object sender, EventArgs e)
        {
            _colorProfiles[comboBoxColorProfile.SelectedIndex].YRed = (float)numericUpDownYR.Value;
        }

        private void numericUpDownXG_ValueChanged(object sender, EventArgs e)
        {
            _colorProfiles[comboBoxColorProfile.SelectedIndex].XGreen = (float)numericUpDownXG.Value;
        }

        private void numericUpDownYG_ValueChanged(object sender, EventArgs e)
        {
            _colorProfiles[comboBoxColorProfile.SelectedIndex].YGreen = (float)numericUpDownXR.Value;
        }

        private void numericUpDownXB_ValueChanged(object sender, EventArgs e)
        {
            _colorProfiles[comboBoxColorProfile.SelectedIndex].XBlue = (float)numericUpDownXB.Value;
        }

        private void numericUpDownYB_ValueChanged(object sender, EventArgs e)
        {
            _colorProfiles[comboBoxColorProfile.SelectedIndex].YBlue = (float)numericUpDownYB.Value;
        }

        private void numericUpDownXW_ValueChanged(object sender, EventArgs e)
        {
            _illuminants[comboBoxIlluminant.SelectedIndex].XWhite = (float)numericUpDownXW.Value;
        }

        private void numericUpDownYW_ValueChanged(object sender, EventArgs e)
        {
            _illuminants[comboBoxIlluminant.SelectedIndex].YWhite = (float)numericUpDownYW.Value;
        }

        private void numericUpDownGamma_ValueChanged(object sender, EventArgs e)
        {
            _colorProfiles[comboBoxColorProfile.SelectedIndex].Gamma = (float)numericUpDownGamma.Value;
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            ShowDialogForImage(ref _selectedImage);
            pictureBoxSelectedImage.Image = _selectedImage;
            pictureBoxSelectedImage.Invalidate();
            _firstImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);
            _secondImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);
            _thirdImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);
            pictureBoxFirst.Image = _firstImage;
            pictureBoxSecond.Image = _secondImage;
            pictureBoxThird.Image = _thirdImage;
        }

        private void buttonSaveOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.ShowNewFolderButton = true;
                dialog.Description = "Choose directory to save";
                string mode = comboBoxMode.SelectedItem.ToString()!;
                string fileNameFirst = $"Image_{DateTime.Now.ToString("MM_dd_mm_ss")}_{mode}_first_channel.png";
                string fileNameSecond = $"Image_{DateTime.Now.ToString("MM_dd_mm_ss")}_{mode}_second_channel.png";
                string fileNameThird = $"Image_{DateTime.Now.ToString("MM_dd_mm_ss")}_{mode}_third_channel.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string chosenDir = dialog.SelectedPath;
                    string fullPathFirst = Path.Combine(chosenDir, fileNameFirst);
                    string fullPathSecond = Path.Combine(chosenDir, fileNameSecond);
                    string fullPathThird = Path.Combine(chosenDir, fileNameThird);
                    ImageFormat format = ImageFormat.Png;
                    _firstImage.Save(fullPathFirst, format);
                    _secondImage.Save(fullPathSecond, format);
                    _thirdImage.Save(fullPathThird, format);
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            _selectedImage = _creator.CreateImage();
            pictureBoxSelectedImage.Image = _selectedImage;
            pictureBoxSelectedImage.Invalidate();
            _firstImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);
            _secondImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);
            _thirdImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);
            pictureBoxFirst.Image = _firstImage;
            pictureBoxSecond.Image = _secondImage;
            pictureBoxThird.Image = _thirdImage;
        }
    }
}
