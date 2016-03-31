using LibUDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuCheff_Cliente
{
	public partial class Form1 : Form
	{
		private int portdestino = 6200;
		private UDPSocket socket;

		public Form1()
		{
			InitializeComponent();

			socket = new UDPSocket(receive);

			comboBox1.Items.Add(new Produto(10, "Vodka"));
			comboBox1.Items.Add(new Produto(50, "Cerveja"));
			comboBox1.Items.Add(new Produto(80, "Tequila"));
			comboBox1.Items.Add(new Produto(55, "Sakeh"));
			comboBox1.Items.Add(new Produto(18, "Frango a Passarinho"));
			comboBox1.Items.Add(new Produto(12, "Bolovo"));
			comboBox1.Items.Add(new Produto(15, "Torresmo"));
			comboBox1.Items.Add(new Produto(90, "Caipirinha"));
			comboBox1.Items.Add(new Produto(20, "Brie"));
			comboBox1.Items.Add(new Produto(23, "Lasanha"));
			comboBox1.Items.Add(new Produto(4, "Suco"));
			comboBox1.Items.Add(new Produto(5, "Sorvete"));
			comboBox1.Items.Add(new Produto(100, "Bala de Hortelã"));
			comboBox1.Items.Add(new Produto(98, "Café"));
			comboBox1.Items.Add(new Produto(102, "Temaki"));
			comboBox1.Items.Add(new Produto(110, "Yakult"));
			comboBox1.Items.Add(new Produto(120, "Fritas"));
			comboBox1.Items.Add(new Produto(115, "Rabada"));
			comboBox1.Items.Add(new Produto(88, "Acompanhante"));
			comboBox1.Items.Add(new Produto(74, "Alho"));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(comboBox1.SelectedItem);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Items.Remove(listBox1.SelectedItem);
		}

		private void enviarPedido_Click(object sender, EventArgs e)
		{
			decimal a = (decimal)(numericUpDown1.Value);

			if (a >= 256 || a <= 0)
			{
				MessageBox.Show("O Número da mesa deve ser entre 1 - 255");
			} else {
				this.build_send();
			}
		}

		private void build_send()
		{
			int qtdItens = listBox1.Items.Count;

			byte[] array = new byte[(qtdItens + 2)];

			array[0] = (byte) (numericUpDown1.Value); //numero da mesa
			array[1] = byte.Parse(qtdItens.ToString()); //quantidade de itens
			int j = 2;

			for (int i = 0; qtdItens > i; ++i)
			{
				Produto t = (Produto)listBox1.Items[i];
				array[j] = byte.Parse(t.id.ToString());
				++j;
			}

			socket.Send(array, hostdestino.Text, portdestino);
		}

		public void receive(byte[] buffer, int size, string ip, int port)
		{

		}



	}
}
