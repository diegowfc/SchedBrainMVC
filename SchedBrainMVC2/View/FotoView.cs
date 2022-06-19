using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedBrainMVC2.View
{
    public partial class FotoView : Form
    {
        public FotoView(string foto)
        {
            InitializeComponent();
            try
            {
                pcbImagem.Image = new Bitmap(foto);
            }
            catch (Exception)
            {
                MessageBox.Show("Foto não encontrada!", "SchedBrain", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
