using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace project
{
    public partial class Form1 : Form
    {
        int d, m;
        public Form1()
        {
            InitializeComponent();
            DateTime date = monthCalendar1.SelectionEnd;
            d = date.Day; // d คือตัวแปร เก็บค่าของวันที่
            m = date.Month; // m คือตัวแปร เก็บค่าของเดือน
            if ((m == 1 && d >= 16) || (m == 2 && d <= 12)) // เงื่อนไขนี้คือ เดือนที่1 ตั้งแต่วันที่มากกว่าหรือเท่ากับ16ขึ้นไปจนถึง เดือนที่2 จนถึงวันที่น้อยกว่าหรือเท่ากับ12
            {
                pictureBox1.Image = Properties.Resources.มังกร; // ที่อยู่ของรูปภาพราศีมังกร 
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีมังกร
            }
            else
            if ((m == 2 && d >= 13) || (m == 3 && d <= 13)) // เงื่อนไขนี้คือ เดือนที่2 ตั้งแต่วันที่มากกว่าหรือเท่ากับ13ขึ้นไปจนถึง เดือนที่3 จนถึงวันที่น้อยกว่าหรือเท่ากับ13
            {
                pictureBox1.Image = Properties.Resources.กุมภ์;// ที่อยู่ของรูปภาพราศีกุมภ์
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีกุมภ์
            }
            else
          if ((m == 3 && d >= 14) || (m == 4 && d <= 12)) // เงื่อนไขนี้คือ เดือนที่3 ตั้งแต่วันที่มากกว่าหรือเท่ากับ14ขึ้นไปจนถึง เดือนที่4 จนถึงวันที่น้อยกว่าหรือเท่ากับ12
            {
                pictureBox1.Image = Properties.Resources.มีน;// ที่อยู่ของรูปภาพราศีมีน
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีมีน
            }
            else
          if ((m == 4 && d >= 13) || (m == 5 && d <= 13)) // เงื่อนไขนี้คือ เดือนที่4 ตั้งแต่วันที่มากกว่าหรือเท่ากับ13ขึ้นไปจนถึง เดือนที่5 จนถึงวันที่น้อยกว่าหรือเท่ากับ13
            {
                pictureBox1.Image = Properties.Resources.เมษ;// ที่อยู่ของรูปภาพราศีเมษ
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีเมษ
            }
            else
          if ((m == 5 && d >= 14) || (m == 6 && d <= 13)) // เงื่อนไขนี้คือ เดือนที่5 ตั้งแต่วันที่มากกว่าหรือเท่ากับ14ขึ้นไปจนถึง เดือนที่6 จนถึงวันที่น้อยกว่าหรือเท่ากับ13
            {
                pictureBox1.Image = Properties.Resources.พฤษภ;// ที่อยู่ของรูปภาพราศีพฤษภ
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีพฤษภ
            }
            else
          if ((m == 6 && d >= 14) || (m == 7 && d <= 14)) // เงื่อนไขนี้คือ เดือนที่6 ตั้งแต่วันที่มากกว่าหรือเท่ากับ14ขึ้นไปจนถึง เดือนที่7 จนถึงวันที่น้อยกว่าหรือเท่ากับ14
            {
                pictureBox1.Image = Properties.Resources.เมถุน;// ที่อยู่ของรูปภาพราศีเมถุน
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีเมถุน
            }
            else
          if ((m == 7 && d >= 15) || (m == 8 && d <= 16)) // เงื่อนไขนี้คือ เดือนที่7 ตั้งแต่วันที่มากกว่าหรือเท่ากับ15ขึ้นไปจนถึง เดือนที่8 จนถึงวันที่น้อยกว่าหรือเท่ากับ16
            {
                pictureBox1.Image = Properties.Resources.กรกฎ;// ที่อยู่ของรูปภาพราศีกรกฏ
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีกรกฏ
            }
            else
          if ((m == 8 && d >= 17) || (m == 9 && d <= 16)) // เงื่อนไขนี้คือ เดือนที่8 ตั้งแต่วันที่มากกว่าหรือเท่ากับ17ขึ้นไปจนถึง เดือนที่9 จนถึงวันที่น้อยกว่าหรือเท่ากับ16
            {
                pictureBox1.Image = Properties.Resources.สิงห์;// ที่อยู่ของรูปภาพราศีสิงห์
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีสิงห์
            }
            else
          if ((m == 9 && d >= 17) || (m == 10 && d <= 16)) // เงื่อนไขนี้คือ เดือนที่9 ตั้งแต่วันที่มากกว่าหรือเท่ากับ17ขึ้นไปจนถึง เดือนที่10 จนถึงวันที่น้อยกว่าหรือเท่ากับ16
            {
                pictureBox1.Image = Properties.Resources.กันย์;// ที่อยู่ของรูปภาพราศีกันย์
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีกันย์
            }
            else
          if ((m == 10 && d >= 17) || (m == 11 && d <= 15)) // เงื่อนไขนี้คือ เดือนที่10 ตั้งแต่วันที่มากกว่าหรือเท่ากับ17ขึ้นไปจนถึง เดือนที่11 จนถึงวันที่น้อยกว่าหรือเท่ากับ15
            {
                pictureBox1.Image = Properties.Resources.ตุลย์;// ที่อยู่ของรูปภาพราศีตุลย์
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีตุลย์
            }
            else
          if ((m == 11 && d >= 16) || (m == 12 && d <= 15)) // เงื่อนไขนี้คือ เดือนที่11 ตั้งแต่วันที่มากกว่าหรือเท่ากับ16ขึ้นไปจนถึง เดือนที่12 จนถึงวันที่น้อยกว่าหรือเท่ากับ15
            {
                pictureBox1.Image = Properties.Resources.พิจิก;// ที่อยู่ของรูปภาพราศีพิจิก
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีพิจิก
            }
            else
          if ((m == 12 && d >= 16) || (m == 1 && d <= 15)) // เงื่อนไขนี้คือ เดือนที่12 ตั้งแต่วันที่มากกว่าหรือเท่ากับ16ขึ้นไปจนถึง เดือนที่1 จนถึงวันที่น้อยกว่าหรือเท่ากับ15
            {
                pictureBox1.Image = Properties.Resources.ธนู;// ที่อยู่ของรูปภาพราศีธนู
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // ขนาดของรูปภาพราศีธนู
            }
            pictureBox1.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = monthCalendar1.SelectionEnd;
            d = date.Day;// d คือตัวแปร เก็บค่าของวันที่
            m = date.Month;// m คือตัวแปร เก็บค่าของเดือน
            if ((m == 1 && d >= 16) || (m == 2 && d <= 12)) // เงื่อนไขนี้คือ เดือนที่1 ตั้งแต่วันที่มากกว่าหรือเท่ากับ16ขึ้นไปจนถึง เดือนที่2 จนถึงวันที่น้อยกว่าหรือเท่ากับ12
            {
                pictureBox1.Image = Properties.Resources.มังกร;// ที่อยู่ของรูปภาพราศีมังกร
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีมังกร
            }
            else
             if ((m == 2 && d >= 13) || (m == 3 && d <= 13))// เงื่อนไขนี้คือ เดือนที่2 ตั้งแต่วันที่มากกว่าหรือเท่ากับ13ขึ้นไปจนถึง เดือนที่3 จนถึงวันที่น้อยกว่าหรือเท่ากับ13
            {
                pictureBox1.Image = Properties.Resources.กุมภ์;// ที่อยู่ของรูปภาพราศีกุมภ์
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีกุมภ์
            }
            else
           if ((m == 3 && d >= 14) || (m == 4 && d <= 12))// เงื่อนไขนี้คือ เดือนที่3 ตั้งแต่วันที่มากกว่าหรือเท่ากับ14ขึ้นไปจนถึง เดือนที่4 จนถึงวันที่น้อยกว่าหรือเท่ากับ12
            {
                pictureBox1.Image = Properties.Resources.มีน;// ที่อยู่ของรูปภาพราศีมีน
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีมีน
            }
            else
           if ((m == 4 && d >= 13) || (m == 5 && d <= 13))// เงื่อนไขนี้คือ เดือนที่4 ตั้งแต่วันที่มากกว่าหรือเท่ากับ13ขึ้นไปจนถึง เดือนที่5 จนถึงวันที่น้อยกว่าหรือเท่ากับ13
            {
                pictureBox1.Image = Properties.Resources.เมษ;// ที่อยู่ของรูปภาพราศีเมษ
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีเมษ
            }
            else
           if ((m == 5 && d >= 14) || (m == 6 && d <= 13))// เงื่อนไขนี้คือ เดือนที่5 ตั้งแต่วันที่มากกว่าหรือเท่ากับ14ขึ้นไปจนถึง เดือนที่6 จนถึงวันที่น้อยกว่าหรือเท่ากับ13
            {
                pictureBox1.Image = Properties.Resources.พฤษภ;// ที่อยู่ของรูปภาพราศีพฤษภ
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีพฤษภ
            }
            else
           if ((m == 6 && d >= 14) || (m == 7 && d <= 14)) // เงื่อนไขนี้คือ เดือนที่6 ตั้งแต่วันที่มากกว่าหรือเท่ากับ14ขึ้นไปจนถึง เดือนที่7 จนถึงวันที่น้อยกว่าหรือเท่ากับ14
            {
                pictureBox1.Image = Properties.Resources.เมถุน;// ที่อยู่ของรูปภาพราศีเมถุน
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีเมถุน
            }
            else
           if ((m == 7 && d >= 15) || (m == 8 && d <= 16)) // เงื่อนไขนี้คือ เดือนที่7 ตั้งแต่วันที่มากกว่าหรือเท่ากับ15ขึ้นไปจนถึง เดือนที่8 จนถึงวันที่น้อยกว่าหรือเท่ากับ16
            {
                pictureBox1.Image = Properties.Resources.กรกฎ;// ที่อยู่ของรูปภาพราศีกรกฏ
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีกรกฏ
            }
            else
           if ((m == 8 && d >= 17) || (m == 9 && d <= 16))// เงื่อนไขนี้คือ เดือนที่8 ตั้งแต่วันที่มากกว่าหรือเท่ากับ17ขึ้นไปจนถึง เดือนที่9 จนถึงวันที่น้อยกว่าหรือเท่ากับ16
            {
                pictureBox1.Image = Properties.Resources.สิงห์;// ที่อยู่ของรูปภาพราศีสิงห์
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีสิงห์
            }
            else
           if ((m == 9 && d >= 17) || (m == 10 && d <= 16))// เงื่อนไขนี้คือ เดือนที่9 ตั้งแต่วันที่มากกว่าหรือเท่ากับ17ขึ้นไปจนถึง เดือนที่10 จนถึงวันที่น้อยกว่าหรือเท่ากับ16
            {
                pictureBox1.Image = Properties.Resources.กันย์;// ที่อยู่ของรูปภาพราศีกันย์
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีกันย์
            }
            else
           if ((m == 10 && d >= 17) || (m == 11 && d <= 15))// เงื่อนไขนี้คือ เดือนที่10 ตั้งแต่วันที่มากกว่าหรือเท่ากับ17ขึ้นไปจนถึง เดือนที่11 จนถึงวันที่น้อยกว่าหรือเท่ากับ15
            {
                pictureBox1.Image = Properties.Resources.ตุลย์;// ที่อยู่ของรูปภาพราศีตุลย์
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีตุลย์
            }
            else
           if ((m == 11 && d >= 16) || (m == 12 && d <= 15))// เงื่อนไขนี้คือ เดือนที่11 ตั้งแต่วันที่มากกว่าหรือเท่ากับ16ขึ้นไปจนถึง เดือนที่12 จนถึงวันที่น้อยกว่าหรือเท่ากับ15
            {
                pictureBox1.Image = Properties.Resources.พิจิก;// ที่อยู่ของรูปภาพราศีพิจิก
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีพิจิก
            }
            else
           if ((m == 12 && d >= 16) || (m == 1 && d <= 15))// เงื่อนไขนี้คือ เดือนที่12 ตั้งแต่วันที่มากกว่าหรือเท่ากับ16ขึ้นไปจนถึง เดือนที่1 จนถึงวันที่น้อยกว่าหรือเท่ากับ15
            {
                pictureBox1.Image = Properties.Resources.ธนู;// ที่อยู่ของรูปภาพราศีธนู
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;// ขนาดของรูปภาพราศีธนู
            }
            pictureBox1.Refresh();
        }

    }
}
