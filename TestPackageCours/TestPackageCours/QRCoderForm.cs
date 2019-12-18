using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPackageCours
{
    public partial class QRCoderForm : Form
    {
        public QRCoderForm()
        {
            InitializeComponent();
        }

        private void QRCoderForm_Load(object sender, EventArgs e)
        {

            QRCodeGenerator monQrCodeGenerator = new QRCodeGenerator();
            QRCodeData monQrCodeData = monQrCodeGenerator.CreateQrCode("http://www.cyrildebrito.info", QRCodeGenerator.ECCLevel.Q);
            QRCode monQrCode = new QRCode(monQrCodeData);
            Bitmap monimage = monQrCode.GetGraphic(10, Color.Black, Color.White, true);
/*            PictureBox maPictureBox = new PictureBox();
            maPictureBox.Image = monimage;*/
            pictureBox1.Image = monimage;
        }
    }
}