﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploUserControl
{
	public partial class Balcao : Form
	{
		public Balcao()
		{
			InitializeComponent();
		}

		public void recebeItem(Itens nomeItem)
		{
			flowLayoutPanel1.Controls.Add(nomeItem);	
        }





	}
}
