using G16.Data;
using G16.Models;

namespace G16
{
    public partial class AppDB : Form
    {
        public AppDB()
        {
            InitializeComponent();
        }

        private void AppDB_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaci�n: Verifica que los campos de descripci�n y precio no est�n vac�os
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                // Si alguno de los campos est� vac�o, muestra un mensaje de error
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Termina la ejecuci�n del m�todo si los campos son inv�lidos
            }

            // Intentar convertir el texto del campo de precio a un n�mero decimal
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                // Si la conversi�n falla, muestra un mensaje de error
                MessageBox.Show("El precio debe ser un n�mero v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Termina la ejecuci�n del m�todo si el precio no es v�lido
            }

            // Crear un nuevo objeto de tipo Producto con los datos introducidos por el usuario
            var producto = new Producto
            { 
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text, // Asigna el valor de descripci�n desde el TextBox
                Precio = precio // Asigna el valor de precio convertido desde el TextBox
            };

            // Conexi�n a la base de datos usando el contexto de Entity Framework
            using (var context = new AppDbContext()) // Crea una instancia de contexto para interactuar con la base de datos
            {
                try
                {
                    // Agrega el nuevo producto al conjunto de productos
                    context.Productos.Add(producto);

                    // Guarda los cambios en la base de datos (esto realmente inserta el nuevo producto)
                    context.SaveChanges();

                    // Muestra un mensaje de �xito al usuario
                    MessageBox.Show("Producto guardado con �xito.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                    // Limpiar los campos de entrada despu�s de guardar el producto
                    txtDescripcion.Clear();
                    txtPrecio.Clear();
                    txtNombre.Clear();
                }
                catch (Exception ex) // Si ocurre un error durante el proceso de guardado
                {
                    // Muestra un mensaje de error con la descripci�n del problema
                    MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // M�todo para cargar los productos en el DataGridView
        private void CargarProductos()
        {
            using (var context = new AppDbContext()) // Usamos el contexto de la base de datos
            {
                // Obtenemos todos los productos de la tabla Productos
                var productos = context.Productos.ToList();

                // Asignamos los productos a la propiedad DataSource del DataGridView
                dataGridViewProductos.DataSource = productos;
            }
        }
    }
}
