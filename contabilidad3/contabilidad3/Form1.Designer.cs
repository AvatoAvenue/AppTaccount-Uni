namespace contabilidad3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Almacen_Carga = new Button();
            label1 = new Label();
            Almacen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Almacen_Abono = new Button();
            Ventas = new TextBox();
            CostosVentas = new TextBox();
            Bancos = new TextBox();
            Capital = new TextBox();
            Proveedores = new TextBox();
            Caja = new TextBox();
            Clientes = new TextBox();
            Ventas_Abono = new Button();
            Ventas_Carga = new Button();
            CostosVentas_Abono = new Button();
            CostosVentas_Carga = new Button();
            Bancos_Abono = new Button();
            Bancos_Carga = new Button();
            Capital_Abono = new Button();
            Capital_Carga = new Button();
            Proveedores_Abono = new Button();
            Proveedores_Carga = new Button();
            Caja_Abono = new Button();
            Caja_Carga = new Button();
            Clientes_Abono = new Button();
            Clientes_Carga = new Button();
            label11 = new Label();
            Empresa = new TextBox();
            Importar = new Button();
            Label12 = new Label();
            Utilidades = new TextBox();
            Utilidades_Cargar = new Button();
            Utilidades_Abonar = new Button();
            SuspendLayout();
            // 
            // Almacen_Carga
            // 
            Almacen_Carga.Location = new Point(169, 130);
            Almacen_Carga.Name = "Almacen_Carga";
            Almacen_Carga.Size = new Size(75, 23);
            Almacen_Carga.TabIndex = 0;
            Almacen_Carga.Text = "Cargar";
            Almacen_Carga.UseVisualStyleBackColor = true;
            Almacen_Carga.Click += Almacen_Carga_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 0);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 1;
            label1.Text = "Inventarios perpetuos";
            // 
            // Almacen
            // 
            Almacen.Location = new Point(63, 127);
            Almacen.Name = "Almacen";
            Almacen.Size = new Size(100, 23);
            Almacen.TabIndex = 2;
            Almacen.TextChanged += Almacen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(138, 25);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 3;
            label2.Text = "Cuentas T";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 130);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Almacen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 172);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 5;
            label4.Text = "Ventas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 204);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 6;
            label5.Text = "Costo de ventas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 242);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 7;
            label6.Text = "Bancos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 280);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 8;
            label7.Text = "Capital";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 319);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 9;
            label8.Text = "Proveedores";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 360);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 10;
            label9.Text = "Caja ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 398);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 11;
            label10.Text = "Clientes";
            // 
            // Almacen_Abono
            // 
            Almacen_Abono.Location = new Point(250, 130);
            Almacen_Abono.Name = "Almacen_Abono";
            Almacen_Abono.Size = new Size(75, 23);
            Almacen_Abono.TabIndex = 12;
            Almacen_Abono.Text = "Abonar";
            Almacen_Abono.UseVisualStyleBackColor = true;
            Almacen_Abono.Click += Almacen_Abono_Click;
            // 
            // Ventas
            // 
            Ventas.Location = new Point(63, 169);
            Ventas.Name = "Ventas";
            Ventas.Size = new Size(100, 23);
            Ventas.TabIndex = 13;
            Ventas.TextChanged += Ventas_TextChanged;
            // 
            // CostosVentas
            // 
            CostosVentas.Location = new Point(100, 201);
            CostosVentas.Name = "CostosVentas";
            CostosVentas.Size = new Size(100, 23);
            CostosVentas.TabIndex = 14;
            CostosVentas.TextChanged += CostosVentas_TextChanged;
            // 
            // Bancos
            // 
            Bancos.Location = new Point(54, 239);
            Bancos.Name = "Bancos";
            Bancos.Size = new Size(100, 23);
            Bancos.TabIndex = 15;
            Bancos.TextChanged += Bancos_TextChanged;
            // 
            // Capital
            // 
            Capital.Location = new Point(55, 277);
            Capital.Name = "Capital";
            Capital.Size = new Size(100, 23);
            Capital.TabIndex = 16;
            Capital.TextChanged += Capital_TextChanged;
            // 
            // Proveedores
            // 
            Proveedores.Location = new Point(82, 316);
            Proveedores.Name = "Proveedores";
            Proveedores.Size = new Size(100, 23);
            Proveedores.TabIndex = 17;
            Proveedores.TextChanged += Proveedores_TextChanged;
            // 
            // Caja
            // 
            Caja.Location = new Point(32, 357);
            Caja.Name = "Caja";
            Caja.Size = new Size(100, 23);
            Caja.TabIndex = 18;
            Caja.TextChanged += Caja_TextChanged;
            // 
            // Clientes
            // 
            Clientes.Location = new Point(54, 395);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(100, 23);
            Clientes.TabIndex = 19;
            Clientes.TextChanged += Clientes_TextChanged;
            // 
            // Ventas_Abono
            // 
            Ventas_Abono.Location = new Point(250, 168);
            Ventas_Abono.Name = "Ventas_Abono";
            Ventas_Abono.Size = new Size(75, 23);
            Ventas_Abono.TabIndex = 21;
            Ventas_Abono.Text = "Abonar";
            Ventas_Abono.UseVisualStyleBackColor = true;
            Ventas_Abono.Click += Ventas_Abono_Click;
            // 
            // Ventas_Carga
            // 
            Ventas_Carga.Location = new Point(169, 168);
            Ventas_Carga.Name = "Ventas_Carga";
            Ventas_Carga.Size = new Size(75, 23);
            Ventas_Carga.TabIndex = 20;
            Ventas_Carga.Text = "Cargar";
            Ventas_Carga.UseVisualStyleBackColor = true;
            Ventas_Carga.Click += Ventas_Carga_Click;
            // 
            // CostosVentas_Abono
            // 
            CostosVentas_Abono.Location = new Point(287, 202);
            CostosVentas_Abono.Name = "CostosVentas_Abono";
            CostosVentas_Abono.Size = new Size(75, 23);
            CostosVentas_Abono.TabIndex = 23;
            CostosVentas_Abono.Text = "Abonar";
            CostosVentas_Abono.UseVisualStyleBackColor = true;
            CostosVentas_Abono.Click += CostosVentas_Abono_Click;
            // 
            // CostosVentas_Carga
            // 
            CostosVentas_Carga.Location = new Point(206, 202);
            CostosVentas_Carga.Name = "CostosVentas_Carga";
            CostosVentas_Carga.Size = new Size(75, 23);
            CostosVentas_Carga.TabIndex = 22;
            CostosVentas_Carga.Text = "Cargar";
            CostosVentas_Carga.UseVisualStyleBackColor = true;
            CostosVentas_Carga.Click += CostosVentas_Carga_Click;
            // 
            // Bancos_Abono
            // 
            Bancos_Abono.Location = new Point(241, 238);
            Bancos_Abono.Name = "Bancos_Abono";
            Bancos_Abono.Size = new Size(75, 23);
            Bancos_Abono.TabIndex = 25;
            Bancos_Abono.Text = "Abonar";
            Bancos_Abono.UseVisualStyleBackColor = true;
            Bancos_Abono.Click += Bancos_Abono_Click;
            // 
            // Bancos_Carga
            // 
            Bancos_Carga.Location = new Point(160, 238);
            Bancos_Carga.Name = "Bancos_Carga";
            Bancos_Carga.Size = new Size(75, 23);
            Bancos_Carga.TabIndex = 24;
            Bancos_Carga.Text = "Cargar";
            Bancos_Carga.UseVisualStyleBackColor = true;
            Bancos_Carga.Click += Bancos_Carga_Click;
            // 
            // Capital_Abono
            // 
            Capital_Abono.Location = new Point(242, 276);
            Capital_Abono.Name = "Capital_Abono";
            Capital_Abono.Size = new Size(75, 23);
            Capital_Abono.TabIndex = 27;
            Capital_Abono.Text = "Abonar";
            Capital_Abono.UseVisualStyleBackColor = true;
            Capital_Abono.Click += Capital_Abono_Click;
            // 
            // Capital_Carga
            // 
            Capital_Carga.Location = new Point(161, 276);
            Capital_Carga.Name = "Capital_Carga";
            Capital_Carga.Size = new Size(75, 23);
            Capital_Carga.TabIndex = 26;
            Capital_Carga.Text = "Cargar";
            Capital_Carga.UseVisualStyleBackColor = true;
            Capital_Carga.Click += Capital_Carga_Click;
            // 
            // Proveedores_Abono
            // 
            Proveedores_Abono.Location = new Point(269, 316);
            Proveedores_Abono.Name = "Proveedores_Abono";
            Proveedores_Abono.Size = new Size(75, 23);
            Proveedores_Abono.TabIndex = 29;
            Proveedores_Abono.Text = "Abonar";
            Proveedores_Abono.UseVisualStyleBackColor = true;
            Proveedores_Abono.Click += Proveedores_Abono_Click;
            // 
            // Proveedores_Carga
            // 
            Proveedores_Carga.Location = new Point(188, 316);
            Proveedores_Carga.Name = "Proveedores_Carga";
            Proveedores_Carga.Size = new Size(75, 23);
            Proveedores_Carga.TabIndex = 28;
            Proveedores_Carga.Text = "Cargar";
            Proveedores_Carga.UseVisualStyleBackColor = true;
            Proveedores_Carga.Click += Proveedores_Carga_Click;
            // 
            // Caja_Abono
            // 
            Caja_Abono.Location = new Point(219, 357);
            Caja_Abono.Name = "Caja_Abono";
            Caja_Abono.Size = new Size(75, 23);
            Caja_Abono.TabIndex = 31;
            Caja_Abono.Text = "Abonar";
            Caja_Abono.UseVisualStyleBackColor = true;
            Caja_Abono.Click += Caja_Abono_Click;
            // 
            // Caja_Carga
            // 
            Caja_Carga.Location = new Point(138, 357);
            Caja_Carga.Name = "Caja_Carga";
            Caja_Carga.Size = new Size(75, 23);
            Caja_Carga.TabIndex = 30;
            Caja_Carga.Text = "Cargar";
            Caja_Carga.UseVisualStyleBackColor = true;
            Caja_Carga.Click += Caja_Carga_Click;
            // 
            // Clientes_Abono
            // 
            Clientes_Abono.Location = new Point(241, 395);
            Clientes_Abono.Name = "Clientes_Abono";
            Clientes_Abono.Size = new Size(75, 23);
            Clientes_Abono.TabIndex = 33;
            Clientes_Abono.Text = "Abonar";
            Clientes_Abono.UseVisualStyleBackColor = true;
            Clientes_Abono.Click += Clientes_Abono_Click;
            // 
            // Clientes_Carga
            // 
            Clientes_Carga.Location = new Point(160, 395);
            Clientes_Carga.Name = "Clientes_Carga";
            Clientes_Carga.Size = new Size(75, 23);
            Clientes_Carga.TabIndex = 32;
            Clientes_Carga.Text = "Cargar";
            Clientes_Carga.UseVisualStyleBackColor = true;
            Clientes_Carga.Click += Clientes_Carga_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 74);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 35;
            label11.Text = "Empresa";
            // 
            // Empresa
            // 
            Empresa.Location = new Point(72, 71);
            Empresa.Name = "Empresa";
            Empresa.Size = new Size(253, 23);
            Empresa.TabIndex = 34;
            Empresa.TextChanged += Empresa_TextChanged;
            // 
            // Importar
            // 
            Importar.Location = new Point(103, 468);
            Importar.Name = "Importar";
            Importar.Size = new Size(113, 23);
            Importar.TabIndex = 36;
            Importar.Text = "importar a excel";
            Importar.UseVisualStyleBackColor = true;
            Importar.Click += Importar_Click;
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(3, 431);
            Label12.Name = "Label12";
            Label12.Size = new Size(59, 15);
            Label12.TabIndex = 37;
            Label12.Text = "Utilidades";
            // 
            // Utilidades
            // 
            Utilidades.Location = new Point(63, 428);
            Utilidades.Name = "Utilidades";
            Utilidades.Size = new Size(100, 23);
            Utilidades.TabIndex = 38;
            // 
            // Utilidades_Cargar
            // 
            Utilidades_Cargar.Location = new Point(169, 428);
            Utilidades_Cargar.Name = "Utilidades_Cargar";
            Utilidades_Cargar.Size = new Size(75, 23);
            Utilidades_Cargar.TabIndex = 39;
            Utilidades_Cargar.Text = "Cargar";
            Utilidades_Cargar.UseVisualStyleBackColor = true;
            Utilidades_Cargar.Click += Utilidades_Cargar_Click;
            // 
            // Utilidades_Abonar
            // 
            Utilidades_Abonar.Location = new Point(250, 428);
            Utilidades_Abonar.Name = "Utilidades_Abonar";
            Utilidades_Abonar.Size = new Size(75, 23);
            Utilidades_Abonar.TabIndex = 40;
            Utilidades_Abonar.Text = "Abonar";
            Utilidades_Abonar.UseVisualStyleBackColor = true;
            Utilidades_Abonar.Click += Utilidades_Abonar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 503);
            Controls.Add(Utilidades_Abonar);
            Controls.Add(Utilidades_Cargar);
            Controls.Add(Utilidades);
            Controls.Add(Label12);
            Controls.Add(Importar);
            Controls.Add(label11);
            Controls.Add(Empresa);
            Controls.Add(Clientes_Abono);
            Controls.Add(Clientes_Carga);
            Controls.Add(Caja_Abono);
            Controls.Add(Caja_Carga);
            Controls.Add(Proveedores_Abono);
            Controls.Add(Proveedores_Carga);
            Controls.Add(Capital_Abono);
            Controls.Add(Capital_Carga);
            Controls.Add(Bancos_Abono);
            Controls.Add(Bancos_Carga);
            Controls.Add(CostosVentas_Abono);
            Controls.Add(CostosVentas_Carga);
            Controls.Add(Ventas_Abono);
            Controls.Add(Ventas_Carga);
            Controls.Add(Clientes);
            Controls.Add(Caja);
            Controls.Add(Proveedores);
            Controls.Add(Capital);
            Controls.Add(Bancos);
            Controls.Add(CostosVentas);
            Controls.Add(Ventas);
            Controls.Add(Almacen_Abono);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Almacen);
            Controls.Add(label1);
            Controls.Add(Almacen_Carga);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Almacen_Carga;
        private Label label1;
        private TextBox Almacen;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button Almacen_Abono;
        private TextBox Ventas;
        private TextBox CostosVentas;
        private TextBox Bancos;
        private TextBox Capital;
        private TextBox Proveedores;
        private TextBox Caja;
        private TextBox Clientes;
        private Button Ventas_Abono;
        private Button Ventas_Carga;
        private Button CostosVentas_Abono;
        private Button CostosVentas_Carga;
        private Button Bancos_Abono;
        private Button Bancos_Carga;
        private Button Capital_Abono;
        private Button Capital_Carga;
        private Button Proveedores_Abono;
        private Button Proveedores_Carga;
        private Button Caja_Abono;
        private Button Caja_Carga;
        private Button Clientes_Abono;
        private Button Clientes_Carga;
        private Label label11;
        private TextBox Empresa;
        private Button Importar;
        private Label Label12;
        private TextBox Utilidades;
        private Button Utilidades_Cargar;
        private Button Utilidades_Abonar;
    }
}