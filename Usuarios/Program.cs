using System.Text.Json;
var usuarios = await Api.GetUsuarios();
var archivo= new Archivo();

for(int i = 0; i < 5; i++){
    var usuario = usuarios[i];
    Console.WriteLine($"Nombre: {usuario.Nombre}");
    Console.WriteLine($"Correo: {usuario.Email}");
    Console.WriteLine($"Domicilio: {usuario.Direccion}");
}


string textoAGuardar = JsonSerializer.Serialize(usuarios);
archivo.GuardarArchivoTexto("usuarios.json", textoAGuardar);