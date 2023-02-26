using ImageAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageConversion : ControllerBase
    {
        [HttpPost]
        public IActionResult Post()
        {
            try
            {
                var imageFile = Request.Form.Files[0];
                int bufferSize = 2048 * 2048;

                using var streamReader = new BinaryReader(imageFile.OpenReadStream());
                using var stringWriter = new StringWriter();
                {
                    var buffer = new byte[bufferSize];
                    var bytesRead = 0;
                    while ((bytesRead = streamReader.Read(buffer, 0, bufferSize)) > 0)
                    {
                        string base64chunk = Convert.ToBase64String(buffer, 0, bytesRead);
                        stringWriter.Write(base64chunk);
                    }
                    string base64string = stringWriter.ToString();

                    var response = new Base64Response() { Base64String = base64string };

                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}