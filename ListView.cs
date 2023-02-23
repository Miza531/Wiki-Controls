// Crear un nuevo ListView
ListView listView1 = new ListView();

// Establecer algunas propiedades
listView1.Width = 200;
listView1.Height = 100;
listView1.View = View.Details;

// Crear algunas columnas
listView1.Columns.Add("Nombre", 100);
listView1.Columns.Add("Edad", 50);

// Crear algunos elementos
string[] row1 = { "Juan", "25" };
string[] row2 = { "María", "30" };
string[] row3 = { "Pedro", "28" };
string[] row4 = { "Ana", "35" };
string[] row5 = { "Carlos", "27" };

// Agregar los elementos al ListView
listView1.Items.Add(new ListViewItem(row1));
listView1.Items.Add(new ListViewItem(row2));
listView1.Items.Add(new ListViewItem(row3));
listView1.Items.Add(new ListViewItem(row4));
listView1.Items.Add(new ListViewItem(row5));

// Agregar el ListView al formulario
this.Controls.Add(listView1);
