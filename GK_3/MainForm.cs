using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GK_3
{
    public partial class MainForm : Form
    {

        private Bitmap? _selectedImage;
        private List<ColorProfile> _colorProfiles = new List<ColorProfile>();
        private List<Illuminant> _illuminants = new List<Illuminant>();
        public MainForm()
        {
            InitializeComponent();
            _selectedImage = ImageFromFile("1669101071_1-pibig-info-p-alukarda-oboi-1.jpg");
            pictureBoxSelectedImage.Image = _selectedImage;
            comboBoxMode.Items.Add("YCrCb");
            comboBoxMode.Items.Add("HCV");
            comboBoxMode.Items.Add("Lab");
            comboBoxMode.SelectedIndex = 0;

            // Adding to lists of profiles and Illuminants
            foreach (ColorProfile.ColorProfileType type in Enum.GetValues(typeof(ColorProfile.ColorProfileType)))
            {
                _colorProfiles.Add(ColorProfile.GenerateColorProfile(type));
            }
            foreach (Illuminant.IlluminantPredefinedType type in Enum.GetValues(typeof(Illuminant.IlluminantPredefinedType)))
            {
                _illuminants.Add(Illuminant.GenerateIlluminant(type));
            }


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
