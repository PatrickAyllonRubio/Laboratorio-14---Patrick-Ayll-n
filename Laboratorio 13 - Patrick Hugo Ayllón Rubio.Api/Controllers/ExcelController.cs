using Laboratorio_13___Patrick_Hugo_Ayllón_Rubio.Infrastructure.Services.Export;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio_13___Patrick_Hugo_Ayllón_Rubio.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExcelExportController : ControllerBase
{
    private readonly ExcelExportService _excelExportService;
    private readonly string _filePath = "C:\\Users\\patri\\OneDrive\\Documentos\\Laboratorios\\" +
                                        "Desarrollo de Aplicaciones Empresariales Avanzado\\Semana 13\\Excels\\excelcreado.xlsx";

    public ExcelExportController()
    {
        _excelExportService = new ExcelExportService();
    }

    [HttpPost("crear")]
    public IActionResult CrearArchivoExcel()
    {
        _excelExportService.FirstExample(_filePath);
        return Ok("Archivo creado exitosamente.");
    }

    [HttpPut("editar")]
    public IActionResult EditarCelda()
    {
        _excelExportService.SecondExample();
        return Ok("Archivo editado exitosamente.");
    }

    [HttpPost("tabla")]
    public IActionResult CrearTabla()
    {
        _excelExportService.ThirdExample();
        return Ok("Tabla creada en nuevo archivo.");
    }

    [HttpPost("estilos")]
    public IActionResult AplicarEstilos()
    {
        _excelExportService.FourthExample();
        return Ok("Archivo con estilos creado.");
    }
}
