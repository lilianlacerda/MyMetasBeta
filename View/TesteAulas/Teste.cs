﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMetasBeta.View
{
    public partial class Teste: Form
    {
        public Teste()
        {
            InitializeComponent();
            CloseTeste();
        }

        //Metodos assincronas 
        private async void CloseTeste()
        {
            await Task.Delay(500);
            this.Close();
        }
    }
}
