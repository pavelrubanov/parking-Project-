using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Text.Json;


namespace Parking
{
    public partial class Parking : Form
    {
        private List<Place> places = new List<Place>();
        private int number_of_free_places;
        private int number_of_all_places;
        private int current_time;
        private string current_date;
        private Place? chosed_place = null;
        public Parking(string current_date, int current_time)
        {
            this.current_date = current_date;
            this.current_time = current_time;
            InitializeComponent();
            init_places();
            read_info();
            number_of_all_places = places.Count();
            gos_number.Enabled = false;
            model.Enabled = false;
            hours.Enabled = false;
            init_places_2();
        }
        private void init_places_2 ()
        {
            for (int i=0;i<places.Count;i++)
            {
                if (places[i].timetable[current_time]==1)
                {
                    places[i].BackgroundImage = Image.FromFile(places[i].path_to_img);
                    places[i].Enabled = false;
                }
            }
        }
        private void init_places()
        {
            for (int i=0; i<12;i++)
            {
                cargo_Place p = new cargo_Place();
                p.Size = new Size(55,127);
                p.Location = new Point(24 + i * 68, 102);
                p.MouseUp += new MouseEventHandler(press);
                Controls.Add(p);
                places.Add(p);
            }
            for (int i=0;i<17;i++)
            {
                usual_Place p = new usual_Place();
                p.Size = new Size(40, 70);
                p.Location = new Point(22+i*47+3*i/8, 473);
                p.MouseUp += new MouseEventHandler(press);
                Controls.Add(p);
                places.Add(p);

                if (i<15)
                {
                    usual_Place p1 = new usual_Place();
                    p1.Size = new Size(40, 70);
                    p1.Location = new Point(22 + i * 47 + 3 * i / 8, 371);
                    p1.MouseUp += new MouseEventHandler(press);
                    Controls.Add(p1);
                    places.Add(p1);

                    usual_Place p2 = new usual_Place();
                    p2.Size = new Size(40, 70);
                    p2.Location = new Point(22 + i * 47 + 3 * i / 8, 294);
                    p2.MouseUp += new MouseEventHandler(press);
                    Controls.Add(p2);
                    places.Add(p2);
                }   
            }

            for (int i=0;i<places.Count();i++)
            {
                places[i].Text = (i+1).ToString();
                places[i].number = i + 1;
            }
            
        }

        public void press(object sender, MouseEventArgs e)
        {
            chosed_place = sender as Place;
            gos_number.Enabled = true;
            model.Enabled = true;
            hours.Enabled = true;
            string type;
            if (chosed_place.GetType()==(new cargo_Place()).GetType()) type = "Грузовое";
            else type = "Обычное";
            ty_place.Text = type;
            cho_place.Text = chosed_place.Text;
            hours.Maximum = chosed_place.get_number_of_free_hours(current_time);
        }
        public void booking(Car c, Place p, int h, int start)
        {
            p.book_hours(start, h, c);
            save();
            MessageBox.Show("Успешно");
            Close();
        }
        private void save()
        {
            List<simple_place> arr = new List<simple_place>();
            for (int i=0;i<places.Count;i++)
            {
                simple_place p = new simple_place();
                arr.Add(p);
                arr[i].number = places[i].number;
                arr[i].free = places[i].free;
                arr[i].cars = places[i].cars;
                arr[i].timetable = places[i].timetable;
            }

            string s = JsonConvert.SerializeObject(arr, Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            string file_name = Directory.GetCurrentDirectory() + "\\data\\" + current_date + ".json";
            using (StreamWriter file = new StreamWriter(file_name))
            {
                file.WriteLine(s);
            }
        }
        private void read_info()
        {
            List<simple_place> arr = new List<simple_place>();
            string file_name = Directory.GetCurrentDirectory() + "\\data\\" + current_date + ".json";
            try
            {
                using (StreamReader file = new StreamReader(file_name))
                {
                    string s = file.ReadToEnd();
                    arr = JsonConvert.DeserializeObject<List<simple_place>>(s);
                }
                for (int i = 0; i < places.Count; i++)
                {
                    places[i].timetable = arr[i].timetable;
                    places[i].cars = arr[i].cars;
                    places[i].free = arr[i].free;
                }
            }
            catch
            {
                ;
            }
            update();


        }
        private void update()
        {
            int co = 0;
            for (int i=0;i<places.Count();i++)
            {
                if (places[i].timetable[current_time]==0) co++;
            }
            number_of_free_places = co;
            label1.Text = "Добро пожаловать! Количество свободных мест: " + number_of_free_places.ToString();   
        }

        private void book_Click(object sender, EventArgs e)
        {
            if (gos_number.Text=="" || model.Text=="")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                Car c;
                if (chosed_place.GetType() == (new cargo_Place()).GetType())
                {
                    c = new Cargo_car(model.Text, gos_number.Text);
                }
                else
                {
                    c = new Passenger_car(model.Text, gos_number.Text);
                }
                booking(c,chosed_place,Convert.ToInt16(hours.Value),current_time);
            }
        }
    }
}