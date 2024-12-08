using GK_3.Converters;
using System.Net.Http.Headers;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GK_3
{
    public partial class MainForm : Form
    {

        private Bitmap? _selectedImage;
        private Bitmap? _firstImage;
        private Bitmap? _secondImage;
        private Bitmap? _thirdImage;
        private LabConverter _labConverter = new LabConverter();
        private List<ColorProfile> _colorProfiles = new List<ColorProfile>();
        private List<Iluminant> _illuminants = new List<Iluminant>();
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

            comboBoxColorProfile.SelectedIndex = 0;
            comboBoxIlluminant.SelectedIndex = 0;

            CheckIfShowParametersColorProfileOnTheScreen();
            CheckIfShowParametersIlluminantOnTheScreen();

            Vector3[,] valuesLab = _labConverter.Convert(_selectedImage!,
                _colorProfiles[comboBoxColorProfile.SelectedIndex], _illuminants[comboBoxIlluminant.SelectedIndex]);

            _firstImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);
            _secondImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);
            _thirdImage = new Bitmap(_selectedImage.Width, _selectedImage.Height);

            _labConverter.DrawToBitmap(_firstImage, _secondImage, _thirdImage, valuesLab);

            pictureBoxFirst.Image = _firstImage;
            pictureBoxSecond.Image = _secondImage;
            pictureBoxThird.Image = _thirdImage;
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
    }
}
