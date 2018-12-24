using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pasajes.Datos;
using Pasajes.Negocio;

namespace AplicacionPantalla
{
    public partial class Form1 : Form
    {
        int cont;
        string cod_pasaje;
        double precio;
        string str_precio;
        string codigo;
        Pasaje pasaje_;
        PasajeAereo pasaje_Aereo;
        PasajeMaritimo pasaje_Maritimo;
        PasajeTerrestre pasaje_Terrestre;

        public Form1()
        {
            InitializeComponent();
           // this.comboBoxBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox11.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox12.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox8.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox9.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAereoTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMarinoTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTerrestreTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            

            //crear strings y variables para rellenar formularios

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox4.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAceptar1_Click(object sender, EventArgs e)
        {
            ////Verificación de relleno de formulario////
            if (!txtNombre.Text.Equals(String.Empty) && !textBox1.Text.Equals(String.Empty) && !comboBox1.Text.Equals(String.Empty)
                && !txtDireccion.Text.Equals(String.Empty) && !txtTelAccidente.Text.Equals(String.Empty) && !txtTelPersonal.Text.Equals(String.Empty)
                && !comboBox2.Text.Equals(String.Empty))
            {
                groupBox1.Visible = true;

                lblTerrestreNumero.Visible = false;
                txtTerrestreNumero.Visible = false;
                lblTerrestreOrigen.Visible = false;
                txtTerrestreOrigen.Visible = false;
                lblTerrestreTipo.Visible = false;
                comboBoxTerrestreTipo.Visible = false;

                lblMarinoNombre.Visible = false;
                txtMarinoNombre.Visible = false;
                lblMarinoTipo.Visible = false;
                comboBoxMarinoTipo.Visible = false;

                lblAereoNombre.Visible = false;
                txtAereoNombre.Visible = false;
                lblAereoAeronave.Visible = false;
                comboBox11.Visible = false;
                lblAereoTipo.Visible = false;
                comboBoxAereoTipo.Visible = false;




            }
            else
            {
                lblEstado1.Text = "Uno de los campos no fue llenado";
            }
        }

        private void btnEdicionAceptar0_Click(object sender, EventArgs e)
        {
            if (!txtEdicionId.Text.Equals(String.Empty))
            {
                //metodo buscar
                //if (si lo encuentra) :
                groupBox2.Visible = true;
            }
            else
            {
                label48.Text = "Debe llenar el campo";
            }
        }

        private void btnEdicionAceptar1_Click(object sender, EventArgs e)
        {
            if (!txtEdicionNombre.Text.Equals(String.Empty) && !txtEdicionRut.Text.Equals(String.Empty) && !comboBox4.Text.Equals(String.Empty) && !txtEdicionDireccion.Text.Equals(String.Empty) 
                && !txtEdicionAccidente.Text.Equals(String.Empty) && !txtEdicionPersonal.Text.Equals(String.Empty) && !comboBox3.Text.Equals(String.Empty))
            {
                groupBox3.Visible = true;

                label22.Visible = false;
                txtEdicionTerrestreNumero.Visible = false;
                label20.Visible = false;
                txtEdicionTerrestreOrigen.Visible = false;
                label14.Visible = false;
                comboBox7.Visible = false;

                label19.Visible = false;
                txtEdicionMarinoMuelle.Visible = false;
                label13.Visible = false;
                comboBox6.Visible = false;

                label18.Visible = false;
                txtEdicionAereoNombre.Visible = false;
                label17.Visible = false;
                comboBox8.Visible = false;
                label11.Visible = false;
                comboBox5.Visible = false;
            }
            else
            {
                label49.Text = "Uno de los campos no fue llenado1";
            }

        }

        private void btnEdicionVolver_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            btnAceptar3.Visible = true;
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;

            if (comboBox12.Text.Equals("Terrestre"))
            {
                lblTerrestreNumero.Visible = true;
                txtTerrestreNumero.Visible = true;
                lblTerrestreOrigen.Visible = true;
                txtTerrestreOrigen.Visible = true;
                lblTerrestreTipo.Visible = true;
                comboBoxTerrestreTipo.Visible = true;
            }
            if (comboBox12.Text.Equals("Marino"))
            {
                lblMarinoNombre.Visible = true;
                txtMarinoNombre.Visible = true;
                lblMarinoTipo.Visible = true;
                comboBoxMarinoTipo.Visible = true;
            }
            if (comboBox12.Text.Equals("Aéreo"))
            {
                lblAereoNombre.Visible = true;
                txtAereoNombre.Visible = true;
                lblAereoAeronave.Visible = true;
                comboBox11.Visible = true;
                lblAereoTipo.Visible = true;
                comboBoxAereoTipo.Visible = true;
            }
        }

        private void btnEdicionAceptar2_Click(object sender, EventArgs e)
        {
                if (comboBox9.Text.Equals("Terrestre"))
                {
                    groupBox7.Visible = true;
                    label22.Visible = true;
                    txtEdicionTerrestreNumero.Visible = true;
                    label20.Visible = true;
                    txtEdicionTerrestreOrigen.Visible = true;
                    label14.Visible = true;
                    comboBox7.Visible = true;
                }
                if (comboBox9.Text.Equals("Marino"))
                {
                    groupBox7.Visible = true;
                    label19.Visible = true;
                    txtEdicionMarinoMuelle.Visible = true;
                    label13.Visible = true;
                    comboBox6.Visible = true;
                }
                if (comboBox9.Text.Equals("Aéreo"))
                {
                    groupBox7.Visible = true;
                    label18.Visible = true;
                    txtEdicionAereoNombre.Visible = true;
                    label17.Visible = true;
                    comboBox8.Visible = true;
                    label11.Visible = true;
                    comboBox5.Visible = true;
                }
        }

        private void btnEdicionVolver_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox7.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox6.Visible = false;
        }

        private void btnBuscarAceptar1_Click(object sender, EventArgs e)
        {
            Pasaje pasaje = new Pasaje();
            if (txtBuscarId.Text.Equals(string.Empty) || txtBuscarId.Text.Equals("id no encontrada"))
            {
                txtBuscarId.Text = "0";

            }
            try
            {
                pasaje.Id = Convert.ToInt32(txtBuscarId.Text);
                if (pasaje.Read1())
                {


                    if (!pasaje.RutPasajero.Equals(string.Empty))
                    {
                        groupBox4.Visible = true;
                        txtBuscarNombre.Text = pasaje.NombrePasajero;
                        txtBuscarAccidentes.Text = pasaje.TelefonoAccidente;
                        txtBuscarDestino.Text = pasaje.DestinoViaje;
                        txtBuscarDireccion.Text = pasaje.DireccionPasajero;
                        txtBuscarFecha.Text = pasaje.FechaViaje.ToShortDateString();
                        txtBuscarId.Text = Convert.ToString(pasaje.Id);
                        txtBuscarNacimiento.Text = pasaje.FechaNacimiento.ToShortDateString();
                        txtBuscarPersonal.Text = pasaje.TelefonoPersonal;
                        txtBuscarRut.Text = pasaje.RutPasajero;
                        if (pasaje.Sexo.Equals(0)) { pasaje.Sexo = "Masculino"; } else { pasaje.Sexo = "Femenino"; }
                        txtBuscarSexo.Text = pasaje.Sexo;




                    }
                    if (pasaje.RutPasajero == null)
                    {
                        txtBuscarId.Text = "id no encontrada";
                    }


                }
                else { txtBuscarId.Text = "id no encontrada"; }

            }
            catch
            {
                txtBuscarId.Text = "id no encontrada";

            }
            
            
        }

        private void btnBuscarAceptar2_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }

        private void btnEliminarAceptar1_Click(object sender, EventArgs e)
        {
            if (!txtEliminarId.Text.Equals(String.Empty))
            {
                pasaje_Aereo = new PasajeAereo();
                pasaje_Aereo.Id = Convert.ToInt32(txtEliminarId.Text);
                pasaje_Aereo.EliminarPasajeAereo();

            }
            else
            {
                label50.Text = "Debe llenar el campo";
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar3_Click(object sender, EventArgs e)
        {
            btnAceptar3.Visible = false;
            if(textBox2.Text.Equals(string.Empty)){textBox2.Text="1";}
            monthCalendario.SelectionRange.Start.Month.ToString();
            ////TERRESTRE////
            if (comboBoxTerrestreTipo.Text.Equals("Bus clásico"))
            {
                cont ++;
                cod_pasaje = cont.ToString();
                codigo = "TER-CLA-" + monthCalendario.SelectionRange.Start.Day.ToString() + monthCalendario.SelectionRange.Start.Month.ToString() + monthCalendario.SelectionRange.Start.Year.ToString() + "-" + cont.ToString();
                precio = 10000;
                

                if (monthCalendario.SelectionRange.Start.Month.ToString().Equals("1")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("2")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("5")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("9")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("12"))
                {
                    precio = precio * 3;                    
                }
                if (comboBox2.Text.Equals("Buenos Aires"))
                {
                    precio = precio * 4;
                }
                str_precio = Convert.ToString(precio);
                lblPrecioFinal.Text = str_precio;
                lblcodigo.Text = codigo;
                precio = 0;
            }
            if (comboBoxTerrestreTipo.Text.Equals("Bus semicama"))
            {
                cont ++;
                cod_pasaje = cont.ToString();
                codigo = "TER-SMC-" + monthCalendario.SelectionRange.Start.Day.ToString() + monthCalendario.SelectionRange.Start.Month.ToString() + monthCalendario.SelectionRange.Start.Year.ToString() + "-" + cont.ToString();
                precio = 15000;

                if (monthCalendario.SelectionRange.Start.Month.ToString().Equals("1")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("2")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("5")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("9")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("12"))
                {
                    precio = precio * 3;
                }
                if (comboBox2.Text.Equals("Buenos Aires"))
                {
                    precio = precio * 4;
                }
                str_precio = Convert.ToString(precio);
                lblPrecioFinal.Text = str_precio;
                lblcodigo.Text = codigo;
                precio = 0;
            }
            if (comboBoxTerrestreTipo.Text.Equals("Bus premium"))
            {
                cont ++;
                cod_pasaje = cont.ToString();
                codigo = "TER-PRE-" + monthCalendario.SelectionRange.Start.Day.ToString() + monthCalendario.SelectionRange.Start.Month.ToString() + monthCalendario.SelectionRange.Start.Year.ToString() + "-" + cont.ToString();
                precio = 20000;

                if (monthCalendario.SelectionRange.Start.Month.ToString().Equals("1")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("2")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("5")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("9")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("12"))
                {
                    precio = precio * 3;
                }
                if (comboBox2.Text.Equals("Buenos Aires"))
                {
                    precio = precio * 4;
                }
                str_precio = Convert.ToString(precio);
                lblPrecioFinal.Text = str_precio;
                lblcodigo.Text = codigo;
                precio = 0;
            }

            ////MARINO////
            if (comboBoxMarinoTipo.Text.Equals("Barcaza"))
            {
                cont ++;
                cod_pasaje = cont.ToString();
                codigo = "MAR-BCS-" + monthCalendario.SelectionRange.Start.Day.ToString() + monthCalendario.SelectionRange.Start.Month.ToString() + monthCalendario.SelectionRange.Start.Year.ToString() + "-" + cont.ToString();
                precio = 5000;

                if (monthCalendario.SelectionRange.Start.Month.ToString().Equals("1")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("2")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("5")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("9")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("12"))
                {
                    precio = precio * 3;
                }
                if (comboBox2.Text.Equals("Buenos Aires"))
                {
                    precio = precio * 4;
                }
                str_precio = Convert.ToString(precio);
                lblPrecioFinal.Text = str_precio;
                lblcodigo.Text = codigo;
                precio = 0;
            }
            if (comboBoxMarinoTipo.Text.Equals("Yate"))
            {
                cont ++;
                cod_pasaje = cont.ToString();
                codigo = "MAR-NYT-" + monthCalendario.SelectionRange.Start.Day.ToString() + monthCalendario.SelectionRange.Start.Month.ToString() + monthCalendario.SelectionRange.Start.Year.ToString() + "-" + cont.ToString();
                precio = 7500;

                if (monthCalendario.SelectionRange.Start.Month.ToString().Equals("1")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("2")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("5")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("9")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("12"))
                {
                    precio = precio * 3;
                }
                if (comboBox2.Text.Equals("Buenos Aires"))
                {
                    precio = precio * 4;
                }
                str_precio = Convert.ToString(precio);
                lblPrecioFinal.Text = str_precio;
                lblcodigo.Text = codigo;
                precio = 0;
            }
            if (comboBoxMarinoTipo.Text.Equals("Crucero"))
            {
                cont ++;
                cod_pasaje = cont.ToString();
                codigo = "MAR-CRU-" + monthCalendario.SelectionRange.Start.Day.ToString() + monthCalendario.SelectionRange.Start.Month.ToString() + monthCalendario.SelectionRange.Start.Year.ToString() + "-" + cont.ToString();
                precio = 10000;

                if (monthCalendario.SelectionRange.Start.Month.ToString().Equals("1")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("2")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("5")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("9")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("12"))
                {
                    precio = precio * 3;
                }
                if (comboBox2.Text.Equals("Buenos Aires"))
                {
                    precio = precio * 4;
                }
                str_precio = Convert.ToString(precio);
                lblPrecioFinal.Text = str_precio;
                lblcodigo.Text = codigo;
                precio = 0;
            }

            ////AEREO////
            if (comboBoxAereoTipo.Text.Equals("Clase económica"))
            {
                cont++;
                cod_pasaje = cont.ToString();
                codigo = "AER-ECO-" + monthCalendario.SelectionRange.Start.Day.ToString() + monthCalendario.SelectionRange.Start.Month.ToString() + monthCalendario.SelectionRange.Start.Year.ToString() + "-" + cont.ToString();
                precio = 40000;

                if (monthCalendario.SelectionRange.Start.Month.ToString().Equals("1")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("2")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("5")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("9")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("12"))
                {
                    precio = precio * 3;
                }
                if (comboBox2.Text.Equals("Buenos Aires"))
                {
                    precio = precio * 4;
                }
                str_precio = Convert.ToString(precio);
                lblPrecioFinal.Text = str_precio;
                lblcodigo.Text = codigo;
                precio = 0;
            }
            if (comboBoxAereoTipo.Text.Equals("Clase ejecutiva"))
            {
                cont++;
                cod_pasaje = cont.ToString();
                codigo = "AER-EJT-" + monthCalendario.SelectionRange.Start.Day.ToString() + monthCalendario.SelectionRange.Start.Month.ToString() + monthCalendario.SelectionRange.Start.Year.ToString() + "-" + cont.ToString();
                precio = 60000;

                if (monthCalendario.SelectionRange.Start.Month.ToString().Equals("1")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("2")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("5")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("9")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("12"))
                {
                    precio = precio * 3;
                }
                if (comboBox2.Text.Equals("Buenos Aires"))
                {
                    precio = precio * 4;
                }
                str_precio = Convert.ToString(precio);
                lblPrecioFinal.Text = str_precio;
                lblcodigo.Text = codigo;
                precio = 0;
            }
            if (comboBoxAereoTipo.Text.Equals("Primera clase"))
            {
                cont++;
                cod_pasaje = cont.ToString();
                codigo = "AER-PRI-" + monthCalendario.SelectionRange.Start.Day.ToString() + monthCalendario.SelectionRange.Start.Month.ToString() + monthCalendario.SelectionRange.Start.Year.ToString() + "-" + cont.ToString();
                precio = 80000;

                if (monthCalendario.SelectionRange.Start.Month.ToString().Equals("1")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("2")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("5")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("9")
                    || monthCalendario.SelectionRange.Start.Month.ToString().Equals("12"))
                {
                    precio = precio * 3;
                }
                if (comboBox2.Text.Equals("Buenos Aires"))
                {
                    precio = precio * 4;
                }
                str_precio = Convert.ToString(precio);
                lblPrecioFinal.Text = str_precio;
                lblcodigo.Text = codigo;
                precio = 0;
            }

            if(comboBox12.Text.Equals("Aéreo"))
            {
                string fecha = txtNacimiento.SelectionRange.Start.ToShortDateString();
                DateTime dt;
                dt=Convert.ToDateTime(fecha);
                string fechav = monthCalendario.SelectionRange.Start.ToShortDateString();
                DateTime dt2;
                dt2 = Convert.ToDateTime(fechav);
                string a = textBox2.Text;


                Pasaje pa = new Pasaje(txtNombre.Text, textBox1.Text, dt, comboBox1.Text, txtDireccion.Text, txtTelAccidente.Text, txtTelPersonal.Text, comboBox2.Text, dt2);
                pa.Create();
                pa = null;
                pa = new Pasaje();
                pa.Read();

                try
                {
                    PasajeAereo paer = new PasajeAereo();
                    paer.IdAereo = Convert.ToInt32(textBox2.Text);
                    paer.Id = pa.Id;
                    paer.NombreAeropuerto = txtAereoNombre.Text;
                    paer.TipoAeronave = comboBox11.Text;
                    paer.CreatePasajeAereo();
                }
                catch { textBox2.Text = "ingrese id"; }
              
                //pasaje_Aereo=new PasajeAereo(txtNombre.Text, textBox1.Text, dt, comboBox1.Text, txtDireccion.Text, txtTelAccidente.Text, txtTelPersonal.Text, comboBox2.Text, dt2, txtAereoNombre.Text, comboBox11.Text, Convert.ToInt32(textBox2.Text) );
                //pasaje_Aereo.CreatePasajeAereo();
            }
            if (comboBox12.Text.Equals("Marino"))
            {
                string fecha = txtNacimiento.SelectionRange.Start.ToShortDateString();
                DateTime dt;
                dt = Convert.ToDateTime(fecha);
                string fechav = monthCalendario.SelectionRange.Start.ToShortDateString();
                DateTime dt2;
                dt2 = Convert.ToDateTime(fechav);
                string a = textBox2.Text;

                Pasaje pa = new Pasaje(txtNombre.Text, textBox1.Text, dt, comboBox1.Text, txtDireccion.Text, txtTelAccidente.Text, txtTelPersonal.Text, comboBox2.Text, dt2);
                pa.Create();
                pa = null;
                pa = new Pasaje();
                pa.Read();
                try
                {
                    PasajeMaritimo pm = new PasajeMaritimo();

                    pm.IdMaritimo = Convert.ToInt32(textBox2.Text);
                    pm.Id = pa.Id;
                    pm.NombreMuelle = txtMarinoNombre.Text;
                    pm.CreatePasajeMaritimo();

                }
                
                    catch
                    {
                      //  new ArgumentException("ingrese id valida");
                        
                        textBox2.Text = "ingrese ID";

                    }


                //pasaje_Maritimo = new PasajeMaritimo(txtNombre.Text, textBox1.Text, dt, comboBox1.Text, txtDireccion.Text, txtTelAccidente.Text, txtTelPersonal.Text, comboBox2.Text, dt2, txtMarinoNombre.Text, Convert.ToInt32(textBox2.Text));
                //pasaje_Maritimo.CreatePasajeMaritimo();
            }

            if (comboBox12.Text.Equals("Terrestre"))
            {
                string fecha = txtNacimiento.SelectionRange.Start.ToShortDateString();
                DateTime dt;
                dt = Convert.ToDateTime(fecha);
                string fechav = monthCalendario.SelectionRange.Start.ToShortDateString();
                DateTime dt2;
                dt2 = Convert.ToDateTime(fechav);
                string a = textBox2.Text;

                Pasaje pa = new Pasaje(txtNombre.Text, textBox1.Text, dt, comboBox1.Text, txtDireccion.Text, txtTelAccidente.Text, txtTelPersonal.Text, comboBox2.Text, dt2);
                pa.Create();
                pa = null;
                pa = new Pasaje();
                pa.Read();

                try
                {
                    PasajeTerrestre pt = new PasajeTerrestre();
                    pt.IdTerrestre = Convert.ToInt32(textBox2.Text);
                    pt.Id = pa.Id;
                    pt.Terminal = txtTerrestreOrigen.Text;
                    pt.NroAsiento = txtTerrestreNumero.Text;
                    pt.CreatePasajeTerrestre();
                }
                catch
                {
                    textBox2.Text = "ingrese id";
                }
                


                //pasaje_Terrestre = new PasajeTerrestre(txtNombre.Text, textBox1.Text, dt, comboBox1.Text, txtDireccion.Text, txtTelAccidente.Text, txtTelPersonal.Text, comboBox2.Text, dt2, Convert.ToInt32(textBox2.Text), txtTerrestreOrigen.Text, txtTerrestreNumero.Text);
                //pasaje_Terrestre.CreatePasajeTerrestre();
            }
        }

        private void btnEdicionAceptar3_Click(object sender, EventArgs e)
        {
            ////Editar pasaje////
        }

        private void txtEliminarId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void btnListarActualizar_Click(object sender, EventArgs e)
        {
            Listalbl.Text = "";
            label38.Text = "ID   nombre     rut       fecha nacimiento       telefono accidente       telefono personal       sexo     direccion pasajero      destino viaje      fecha viaje";
            ColeccionPasaje cp = new ColeccionPasaje();

            foreach (Pasaje p in cp.ListarPasajes())
            {
                if (p.Sexo.Equals(0)) { p.Sexo = "Masculino"; } else { p.Sexo = "Femenino"; }

                Listalbl.Text = Listalbl.Text + "\n" + p.Id + "  |   " + p.NombrePasajero + "  |  " + p.RutPasajero + "   |  " + p.FechaNacimiento.ToShortDateString() + "  |   " + p.TelefonoAccidente + "  |   " + p.TelefonoPersonal + "   |   " + p.Sexo + "   |   " + p.DireccionPasajero + "   |   " + p.DestinoViaje + "   |   " + p.FechaViaje.ToShortDateString() + "\n";
            }
			{
                //Listalbl.Text=Listalbl.Text+"\nasd";
			 
			}
            //Listalbl.Text
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/*
Bus clásico
Bus semicama
Bus premium

Barcaza
Yate
Crucero

Clase económica
Clase ejecutiva
Primera clase
*/