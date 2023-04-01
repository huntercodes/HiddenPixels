using System;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiddenPixels
{
    public partial class Form1 : Form
    {
        private string inputFileLocation;
        private string outputFileLocation;

        public Form1()
        {
            InitializeComponent();

            // Set the FormBorderStyle to None
            this.FormBorderStyle = FormBorderStyle.None;

            // Create and add the custom title bar
            AddCustomTitleBar();

            // Create a linear gradient brush with three color stops for the background color
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.Green,
                Color.Blue,
                LinearGradientMode.Vertical);

            gradientBrush.InterpolationColors = new ColorBlend(3)
            {
                Colors = new[] { ColorTranslator.FromHtml("#408E91"), ColorTranslator.FromHtml("#245953"), ColorTranslator.FromHtml("#408E91") },
                Positions = new[] { 0f, 0.5f, 1f }
            };

            // Set the form's transparency key to the same color as the gradient's starting color
            this.TransparencyKey = Color.Green;

            // Set the form's background image to the gradient brush
            this.BackgroundImage = new Bitmap(this.Width, this.Height);
            Graphics.FromImage(this.BackgroundImage).FillRectangle(gradientBrush, this.ClientRectangle);

            // Set rounded corners
            SetRoundedCorners(30);
            this.Resize += (sender, e) =>
            {
                SetRoundedCorners(30);
            };
        }

        private void AddCustomTitleBar()
        {
            Panel titleBar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 35,
                BackColor = Color.FromArgb(48, 48, 48)
            };
            this.Controls.Add(titleBar);

            // Title label
            Label titleLabel = new Label
            {
                Text = "Hidden Pixel",
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Franklin Gothic", 11f, FontStyle.Regular),
                AutoSize = false,
                Width = 150,
                Height = 30,
                TextAlign = ContentAlignment.MiddleCenter
            };
            titleLabel.Location = new Point((titleBar.Width - titleLabel.Width) / 2, 0);
            titleLabel.Anchor = AnchorStyles.Top;
            titleBar.Controls.Add(titleLabel);

            // Close button
            Label closeButton = new Label
            {
                Text = "×",
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Franklin Gothic", 14f, FontStyle.Bold),
                AutoSize = false,
                Width = 35,
                Height = 35,
                TextAlign = ContentAlignment.MiddleCenter
            };
            closeButton.Location = new Point(this.Width - closeButton.Width, 0);
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.MouseEnter += (sender, e) => closeButton.BackColor = Color.FromArgb(232, 17, 35);
            closeButton.MouseLeave += (sender, e) => closeButton.BackColor = Color.Transparent;
            closeButton.Click += (sender, e) => this.Close();
            closeButton.TextAlign = ContentAlignment.MiddleCenter;
            titleBar.Controls.Add(closeButton);

            // Minimize button
            Label minimizeButton = new Label
            {
                Text = "−",
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Franklin Gothic", 14f, FontStyle.Bold),
                AutoSize = false,
                Width = 35,
                Height = 35,
                TextAlign = ContentAlignment.MiddleCenter
            };
            minimizeButton.Location = new Point(this.Width - closeButton.Width - minimizeButton.Width, 0);
            minimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeButton.MouseEnter += (sender, e) => minimizeButton.BackColor = Color.FromArgb(209, 209, 209);
            minimizeButton.MouseLeave += (sender, e) => minimizeButton.BackColor = Color.Transparent;
            minimizeButton.Click += (sender, e) => this.WindowState = FormWindowState.Minimized;
            minimizeButton.TextAlign = ContentAlignment.MiddleCenter;
            titleBar.Controls.Add(minimizeButton);

            // Implement mouse event handlers to enable dragging the form using the custom title bar.
            bool isDragging = false;
            Point dragStart = new Point();

            titleBar.MouseDown += (sender, e) =>
            {
                isDragging = true;
                dragStart = new Point(e.X, e.Y);
            };

            titleBar.MouseMove += (sender, e) =>
            {
                if (isDragging)
                {
                    Point p = PointToScreen(e.Location);
                    this.Location = new Point(p.X - dragStart.X, p.Y - dragStart.Y);
                }
            };

            titleBar.MouseUp += (sender, e) =>
            {
                isDragging = false;
            };
        }

        private void SetRoundedCorners(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }

        public static byte[] EncryptStringToBytes_Aes(string plainText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        return msEncrypt.ToArray();
                    }
                }
            }
        }

        public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFileLocation))
            {
                MessageBox.Show("Please select a file to decrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = txtPasswordDecrypt.Text;

            // Generate a key and IV from the password
            using (var derivedBytes = new Rfc2898DeriveBytes(password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 }, 10000))
            {
                byte[] key = derivedBytes.GetBytes(32); // AES-256 key size
                byte[] iv = derivedBytes.GetBytes(16); // AES block size

                // Read the encrypted file
                byte[] encryptedBytes = File.ReadAllBytes(inputFileLocation);

                // Decrypt the content
                string decryptedText = DecryptStringFromBytes_Aes(encryptedBytes, key, iv);

                // Convert decrypted text to image
                byte[] decryptedImageBytes = Convert.FromBase64String(decryptedText);
                using (var ms = new MemoryStream(decryptedImageBytes))
                {
                    Image decryptedImage = Image.FromStream(ms);

                    // Display the decrypted image in a new Form
                    var form = new Form();
                    form.Size = new Size(Math.Min(decryptedImage.Width + 30, Screen.PrimaryScreen.Bounds.Width - 100),
                                         Math.Min(decryptedImage.Height + 50, Screen.PrimaryScreen.Bounds.Height - 100));
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.FormBorderStyle = FormBorderStyle.FixedDialog;
                    form.MaximizeBox = false;
                    form.MinimizeBox = false;
                    form.Text = "Decrypted Image";

                    var pictureBox = new PictureBox();
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Image = decryptedImage;

                    form.Controls.Add(pictureBox);
                    form.ShowDialog();
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFileLocation))
            {
                MessageBox.Show("Please select a file to encrypt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = txtPasswordEncrypt.Text;

            // Generate a key and IV from the password
            using (var derivedBytes = new Rfc2898DeriveBytes(password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 }, 10000))
            {
                byte[] key = derivedBytes.GetBytes(32); // AES-256 key size
                byte[] iv = derivedBytes.GetBytes(16); // AES block size

                // Read the image file
                byte[] imageBytes = File.ReadAllBytes(inputFileLocation);

                // Convert the image to a Base64 string
                string imageText = Convert.ToBase64String(imageBytes);

                // Encrypt the Base64 string
                byte[] encryptedBytes = EncryptStringToBytes_Aes(imageText, key, iv);

                // Save the encrypted data to a file
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Encrypted Files (*.hp)|*.hp|All Files (*.*)|*.*";
                    saveFileDialog.DefaultExt = "hp";
                    saveFileDialog.AddExtension = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        outputFileLocation = saveFileDialog.FileName;
                        File.WriteAllBytes(outputFileLocation, encryptedBytes);
                        MessageBox.Show("Image encrypted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnBrowseDecrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Encrypted Files (*.hp)|*.hp|All Files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFileLocation = openFileDialog.FileName;
                    txtFileDecrypt.Text = inputFileLocation;
                }
            }
        }

        private void btnBrowseEncrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All Files (*.*)|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFileLocation = openFileDialog.FileName;
                    txtFileEncrypt.Text = inputFileLocation;
                }
            }
        }

        private void txtPasswordDecrypt_TextChanged(object sender, EventArgs e)
        {
            btnDecrypt.Enabled = !string.IsNullOrEmpty(txtPasswordDecrypt.Text);
        }

        private void txtPasswordEncrypt_TextChanged(object sender, EventArgs e)
        {
            btnEncrypt.Enabled = !string.IsNullOrEmpty(txtPasswordEncrypt.Text);
        }
    }
}
