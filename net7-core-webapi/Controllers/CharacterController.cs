using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using net7_core_webapi.Model;

namespace net7_core_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private List<Character> list_character = new List<Character>(){
            new Character(1, "Nguyễn Hữu Nam", "06/06/2002", "Bình Thuận"),
            new Character(2, "Nguyễn Văn A", "16/06/2002", "Lâm Đồng"),
            new Character(3, "Nguyễn Văn B", "12/02/2001", "Đà Lạt"),
            new Character(4, "Nguyễn Văn C", "26/04/2002", "Hà Giang"),
            new Character(5, "Nguyễn Văn A", "30/06/2002", "Hà Nam")
        };



        [HttpGet(Name = "get/information/{ID}")]
        public ActionResult<Character> GetInformationCharacter(long ID){
            Character? character = list_character.FirstOrDefault(item => item.ID == ID);
            if(character == null) return NotFound();
            return Ok(character);
        }




        [HttpGet(Name = "get/information")]
        public ActionResult<Character> GetInformationCharacterHaveParam(long ID){
            Character? character = list_character.Where(item => item.ID == ID).FirstOrDefault();
            if(character == null) return NotFound();
            return Ok(character);
        }


        [HttpGet(Name = "get/list[controller]")]
        public ActionResult<List<Character>> GetListCharacter(){
            return Ok(list_character);
        }
    }
}