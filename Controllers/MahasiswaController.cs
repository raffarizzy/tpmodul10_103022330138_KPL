using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul10_103022330138.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa {Nama = "Frizam Dafa Maulana", NIM = "103022300011"},
            new Mahasiswa {Nama = "Naufal Muhammad Dzulfikar", NIM = "103022300021"},
            new Mahasiswa {Nama = "Bagas Pratama", NIM = "103022300035 "},
            new Mahasiswa {Nama = "Riziq Rizwan", NIM = "103022300119"},
            new Mahasiswa {Nama = "Raffa Rizky Febryan", NIM = "103022330138"}
        };
        
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }
    }
}
