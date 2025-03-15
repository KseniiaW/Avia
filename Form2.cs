using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace Avia
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=localhost;Port=5432;Database=avia;User Id=weberxks; Password=yarik_3105";

        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImage = Image.FromFile("plane.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearch.Click += new EventHandler(buttonSearch_Click);
            exitButton.Click += new EventHandler(exitButton_Click);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string phoneNumber = phoneNumberTextBox.Text.Trim();
            string passengerName = passengerNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(passengerName))
            {
                MessageBox.Show("Пожалуйста, введите номер телефона и ФИО пассажира.");
                return;
            }

            DataTable flightInfo = SearchFlightInfo(phoneNumber, passengerName);

            if (flightInfo != null && flightInfo.Rows.Count > 0)
            {
                string ticketNumber = flightInfo.Rows[0]["Номер_билета"].ToString();

                Form1 form1 = new Form1(flightInfo, passengerName, ticketNumber);
                form1.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Информация о рейсе не найдена.");
            }
        }

        private DataTable SearchFlightInfo(string phoneNumber, string passengerName)
        {
            using (NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString))
            {
                sqlConnection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand())
                {
                    command.Connection = sqlConnection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"
                        SELECT 
                            f.flight_no AS Номер_рейса,
                            f.scheduled_departure AS Время_вылета,
                            dep.airport_name AS Аэропорт_отправления,
                            arr.airport_name AS Аэропорт_прибытия,
                            a.model AS Самолет,
                            a.range AS Дальность_полета,
                            t.ticket_no AS Номер_билета
                        FROM 
                            bookings.tickets t
                        JOIN 
                            bookings.ticket_flights tf ON t.ticket_no = tf.ticket_no
                        JOIN 
                            bookings.flights f ON tf.flight_id = f.flight_id
                        JOIN 
                            bookings.airports dep ON f.departure_airport = dep.airport_code
                        JOIN 
                            bookings.airports arr ON f.arrival_airport = arr.airport_code
                        JOIN 
                            bookings.aircrafts a ON f.aircraft_code = a.aircraft_code
                        WHERE 
                            t.contact_data::text LIKE @phoneNumber 
                            AND t.passenger_name = @passengerName;";

                    command.Parameters.AddWithValue("@phoneNumber", "%" + phoneNumber + "%");
                    command.Parameters.AddWithValue("@passengerName", passengerName);

                    using (NpgsqlDataReader dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            DataTable data = new DataTable();
                            data.Load(dataReader);
                            return data;
                        }
                    }
                }
            }
            return null;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}