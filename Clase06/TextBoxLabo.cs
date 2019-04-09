using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06
{
    public class TextBoxLabo: TextBox
    {

        
        [Category("Apariencia")]
        [Description("Muestra el mensaje detras ")]
        public string PlaceHolder { get; set; }

        private System.Drawing.Color color;

        public TextBoxLabo() : base()
        {
            color = this.ForeColor;
            this.Text = this.PlaceHolder;
            this.ForeColor = System.Drawing.Color.Gray;
            this.GotFocus += new EventHandler(RemoveText);
            this.LostFocus += new EventHandler(AddText);            
        }





        public void RemoveText(object sender, EventArgs e)
        {
            if (this.Text == this.PlaceHolder)
            {
                this.ForeColor = color;
                this.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                this.ForeColor = System.Drawing.Color.Gray;
                this.Text = this.PlaceHolder;
            }
        }
    }
}
