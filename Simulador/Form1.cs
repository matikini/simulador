using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Simulador
{
    public partial class Form1 : Form
    {
        string Equipos = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Z:\SimuladoraxelACTUALIZADO\30equiposconposiciones2.mdb";
        OleDbConnection conn = new OleDbConnection();
        Random rand = new Random();
        List<Equipo> ListaEq = new List<Equipo>();
        Label nombregol;
       
        public Form1()
        {
            InitializeComponent();
            
            Consulta.CommandType = CommandType.StoredProcedure;
            Consulta.CommandText = "Consulta1";
            OleDbDataReader drEquipos = Consulta.ExecuteReader();
            while (drEquipos.Read())
            {
                Equipo UnEquipo = new Equipo();
                UnEquipo.nombre = drEquipos["equipo"].ToString();
                UnEquipo.fuerza = drEquipos["fuerza"].ToString();
                ListaEq.Add(UnEquipo);
                comboBox1.Items.Add(UnEquipo.nombre);
                comboBox2.Items.Add(UnEquipo.nombre);
            }
            OleDbCommand Consulta2 = conn.CreateCommand();
			Consulta2.CommandType = CommandType.StoredProcedure;
			Consulta2.CommandText = "Consulta2";
			OleDbDataReader drJugadores = Consulta2.ExecuteReader();
			while (drJugadores.Read())
			{
				Jugador UnJugador = new Jugador();
				UnJugador.nombre = drJugadores["Nombre"].ToString();
				UnJugador.apellido = drJugadores["Apellido"].ToString();
				UnJugador.equipo = drJugadores["Equipo"].ToString();
				UnJugador.ID = Convert.ToInt32(drJugadores["ID"].ToString());
				for (int i = 0; i < ListaEq.Count; i++)
				{
					if (UnJugador.equipo == ListaEq[i].nombre)
					{
						ListaEq[i].Jugadores.Add(UnJugador);
                        break;
					}

				}
			}
            conn.Close();
            if (comboBox1.Items.Count > 0)
            {
                this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            if (comboBox2.Items.Count > 0)
            {
                this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            
        }

        public OleDbConnection conexion()
        {
            conn.ConnectionString = Equipos;
            conn.Open();
            OleDbCommand Consulta = conn.CreateCommand();
            return 
        }

        private void BTNJugar_Click_1(object sender, EventArgs e)
        {
           
            lblGolesLocal.Visible = false;
            lblGolesVisitante.Visible = false;
            Equipo Local = new Equipo();
            Equipo Visitante = new Equipo();
            Local.nombre = comboBox1.Text;
            Visitante.nombre = comboBox2.Text;
            for (int i = 0; i < ListaEq.Count; i++)
            {
                if (Local.nombre == ListaEq[i].nombre)
                {
                    Local = ListaEq[i];                   
                }
                if (Visitante.nombre == ListaEq[i].nombre)
                {
                    Visitante = ListaEq[i];                    
                }
                if (Local.fuerza != null && Visitante.fuerza != null)
                {
                    break;
                }
            }
            if (Local.nombre == Visitante.nombre || Local.nombre == "" || Visitante.nombre == "")
            {
                MessageBox.Show("Por favor ingrese correctamente los equipos");
            }
            else
            {
                for (int i = 0; i < ListaEq.Count; i++)
			{
                if (Local.nombre == ListaEq[i].nombre)
                {
                    Local.fuerza = ListaEq[i].fuerza;
                }
                if (Visitante.nombre == ListaEq[i].nombre)
                {
                    Visitante.fuerza = ListaEq[i].fuerza;
                }
			}
            
                int gol1 = 0;
                int gol2 = 0;
                int num1 = 0;
                int num2 = 0;
                int fuerzalocal = Convert.ToInt16(Local.fuerza);
                int fuerzavisitante = Convert.ToInt16(Visitante.fuerza);
                Convert.ToInt32(fuerzalocal);
                Convert.ToInt32(fuerzavisitante);
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        num1 = rand.Next(0, fuerzalocal);
                    }
                    if (i == 1)
                    {
                        num2 = rand.Next(0, fuerzavisitante);
                    }
                }
                Random goles = new Random();
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        gol1 = num1 / goles.Next(20, 40);
                    }
                    if (i == 1)
                    {
                        gol2 = num2 / goles.Next(20, 40);
                    }
                }
                Convert.ToString(gol1);
                Convert.ToString(gol2);
                MessageBox.Show(Local.nombre + " " + gol1 + "-" + gol2 + " " + Visitante.nombre, "Resultado parcial", MessageBoxButtons.OK);
                Convert.ToInt32(gol1);
                Convert.ToInt32(gol2);
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        num1 = rand.Next(0, fuerzalocal);
                    }
                    if (i == 1)
                    {
                        num2 = rand.Next(0, fuerzavisitante);
                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        gol1 += num1 / goles.Next(20, 40);
                    }
                    if (i == 1)
                    {
                        gol2 += num2 / goles.Next(20, 40);
                    }
                }
                
                MessageBox.Show(Local.nombre + " " + gol1 + "-" + gol2 + " " + Visitante.nombre, "Resultado Final", MessageBoxButtons.OK);
                lblGolesLocal.Visible = true;
                lblGolesVisitante.Visible = true;
                int pos = 275;
				Random Asignacion = new Random();
                int IDgol = 0;
                int IDmin = 99999;
                int IDmax = 0;
                for (int r = 0; r < Local.Jugadores.Count; r++)
                {
                    if (Local.Jugadores[r].ID < IDmin)
                    {
                        IDmin = Local.Jugadores[r].ID;
                    }
                    if (Local.Jugadores[r].ID > IDmax)
                    {
                        IDmax = Local.Jugadores[r].ID;
                    }
                }
                for (int i = 0; i < gol1; i++)
                {
                    nombregol = new Label();
                    nombregol.Name = i.ToString();  
                    //nombregol.Location = new Point(15, pos);                    
                    if (IDmin != 99999 && IDmax != 0)
                    {
                        IDgol = Asignacion.Next(IDmin, IDmax);
                        for (int q = 0; q < Local.Jugadores.Count; q++)
                        {
                            if (IDgol == Local.Jugadores[q].ID)
                            {
                                IDgol = q;
                                break;
                            }
                        }
                        nombregol.Text = Local.Jugadores[IDgol].nombre + " " + Local.Jugadores[IDgol].apellido;
                        this.dgvLocal.Rows.Add(nombregol.Text);
                        IDgol = 0;                      

                    }
                }
                IDmin = 99999;
                IDmax = 0;

                for (int zz = 0; zz < Visitante.Jugadores.Count; zz++)
                {
                    if (Visitante.Jugadores[zz].ID < IDmin)
                    {
                        IDmin = Visitante.Jugadores[zz].ID;
                    }
                    if (Visitante.Jugadores[zz].ID > IDmax)
                    {
                        IDmax = Visitante.Jugadores[zz].ID;
                    }
                }

                for (int i = 0; i < gol2; i++)
                {
                    nombregol = new Label();
                    nombregol.Name = i.ToString();                   
                    //nombregol.Location = new Point(250, pos);            

                    
                    if (IDmin != 99999 && IDmax != 0)
                    {
                        IDgol = Asignacion.Next(IDmin, IDmax);
                        for (int aa = 0; aa < Visitante.Jugadores.Count; aa++)
                        {
                            if (IDgol == Visitante.Jugadores[aa].ID)
                            {
                                IDgol = aa;
                                break;
                            }
                        }
                        nombregol.Text = Visitante.Jugadores[IDgol].nombre + " " + Visitante.Jugadores[IDgol].apellido;
                        this.dgvVisitante.Rows.Add(nombregol.Text);
                        pos += 30;
                        IDgol = 0;
                        
                    }
                }
                IDmin = 99999;
                IDmax = 0;
            }
        }        

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvLocal.Rows.Clear();
            dgvVisitante.Rows.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form2 formaSiguiente = new Form2();
            this.Hide();
            formaSiguiente.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
