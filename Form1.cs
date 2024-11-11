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
            // Validación: Verifica que los campos de descripción y precio no estén vacíos
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                // Si alguno de los campos está vacío, muestra un mensaje de error
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Termina la ejecución del método si los campos son inválidos
            }

            // Intentar convertir el texto del campo de precio a un número decimal
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                // Si la conversión falla, muestra un mensaje de error
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Termina la ejecución del método si el precio no es válido
            }

            // Crear un nuevo objeto de tipo Producto con los datos introducidos por el usuario
            var producto = new Producto
            { 
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text, // Asigna el valor de descripción desde el TextBox
                Precio = precio // Asigna el valor de precio convertido desde el TextBox
            };

            // Conexión a la base de datos usando el contexto de Entity Framework
            using (var context = new AppDbContext()) // Crea una instancia de contexto para interactuar con la base de datos
            {
                try
                {
                    // Agrega el nuevo producto al conjunto de productos
                    context.Productos.Add(producto);

                    // Guarda los cambios en la base de datos (esto realmente inserta el nuevo producto)
                    context.SaveChanges();

                    // Muestra un mensaje de éxito al usuario
                    MessageBox.Show("Producto guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                    // Limpiar los campos de entrada después de guardar el producto
                    txtDescripcion.Clear();
                    txtPrecio.Clear();
                    txtNombre.Clear();
                }
                catch (Exception ex) // Si ocurre un error durante el proceso de guardado
                {
                    // Muestra un mensaje de error con la descripción del problema
                    MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Método para cargar los productos en el DataGridView
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
