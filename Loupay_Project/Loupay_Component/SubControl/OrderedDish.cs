﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loupay_Component.SubControl
{
    public partial class OrderedDish : UserControl
    {
        public OrderedDish()
        {
            InitializeComponent();
            this.nud_soluong.Minimum = 1;
        }

        public void SetImage(string path)
        {
            try
            {
                Bitmap bm = new Bitmap(path);
                this.pictureBox1.Image = new Bitmap(bm, new Size(70, 70));
            }
            catch
            {
                this.pictureBox1.Image = new Bitmap(Properties.Resources.noimage, new Size(70, 70));
            }
        }

        public void SetPrice(decimal price)
        {
            this.label_price.Text = price.ToString();
        }

        public void SetName(string name)
        {
            this.label_tenmon.Text = name;
        }

        public void SetNudValue(int value)
        {
            this.nud_soluong.Value = value;
        }
    }
}
