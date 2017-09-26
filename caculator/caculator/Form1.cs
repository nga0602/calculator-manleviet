using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        bool istypingNumber= false;
        enum PhepToan {NONE, cong, tru, nhan, chia}
        PhepToan pheptoan;
        double nho;
         
        private void Nhapso(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Nhapso(btn.Text);
        }
      private void Nhapso( string so)
        {
            if (istypingNumber)
                lbldisplay.Text = lbldisplay.Text + so;
            else
            {
                lbldisplay.Text = so;
                istypingNumber = true;
            }

        }
      private void NhapPhepToan(object sender, EventArgs e)
      {
          if (nho != 0)
          TinhKetQua();
          Button btn = (Button)sender;
         switch (btn.Text)
         {
             case "+":pheptoan = PhepToan.cong; break;
             case "-":pheptoan = PhepToan.tru; break;
             case "*":pheptoan = PhepToan.nhan; break;
             case "/":pheptoan = PhepToan.chia; break;
         }
         nho = double.Parse(lbldisplay.Text);
         istypingNumber = false;
       }
      private void TinhKetQua()
      {
          double tam = double.Parse(lbldisplay.Text);
          double ketqua = 0.0;
          switch(pheptoan)
          {
              case PhepToan.cong: ketqua = nho + tam; break;
              case PhepToan.tru: ketqua = nho - tam; break;
              case PhepToan.nhan: ketqua = nho * tam; break;
              case PhepToan.chia: ketqua = nho / tam; break;
             
          }
          lbldisplay.Text = ketqua.ToString();

      }

      private void btnbang_Click(object sender, EventArgs e)
      {
          TinhKetQua();
          istypingNumber = false;
          nho = 0;
          pheptoan = PhepToan.NONE; 

      }

      private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
      {
          switch(e.KeyChar)
          {
              case '0':
              case '1':
              case '2':
              case '3':
              case '4':
              case '5':
              case '6':
              case '7':
              case '8':
              case '9':
                  Nhapso("" + e.KeyChar);
                  break;

              case '+':
                  btncong.PerformClick();
                  break;
              case '-':
                  btntru.PerformClick();
                  break;
              case '*':
                  btnnhan.PerformClick();
                  break;
              case '/':
                  btnchia.PerformClick();
                  break;
              case '=':
                  btnbang.PerformClick();
                  break;
              default:
                  break;
          }
      }

      private void btncan_Click(object sender, EventArgs e)
      {
          lbldisplay.Text = (Math.Sqrt(Double.Parse(lbldisplay.Text))).ToString();
      }

      private void btndoidau_Click(object sender, EventArgs e)
      {
          lbldisplay.Text = (-1 * (double.Parse(lbldisplay.Text))).ToString();
      }

      private void btnphantram_Click(object sender, EventArgs e)
      {
          lbldisplay.Text = ((double.Parse(lbldisplay.Text) / 100)).ToString();
      }
      private void btnXoa_Click(object sender, EventArgs e)
      {
          {
              if (lbldisplay.Text.Length > 0)
                  lbldisplay.Text = lbldisplay.Text.Remove(lbldisplay.Text.Length - 1, 1);
              if (lbldisplay.Text == "")
              {
                  lbldisplay.Text = "0";
              }
          }
      }

        private void btnNho_Click(object sender, EventArgs e)
        {
            nho = 0;
            lbldisplay.Text = "0";
        }
      }
    }

