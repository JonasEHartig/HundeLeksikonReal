using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HundeLeksikon.Shared;
using HundeLeksikon.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace HundeLeksikon.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HundeLeksikonController : ControllerBase
    {
        private readonly DataContext _context;

        public HundeLeksikonController(DataContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<HundeData>>> GetAllHunde()
        {
            var list = await _context.HundeData.ToListAsync();


            return Ok(list);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<HundeData>> GetHunde(int Id)
        {
            var dbHundeData = await _context.HundeData.FindAsync(Id);
            if (dbHundeData == null)
            {
                return NotFound("Hunden med dette ID findes ikke");
            }

            return Ok(dbHundeData);
        }

        [HttpPost]
        public async Task<ActionResult<List<HundeData>>> CreateHunde(HundeData hundeData)
        {
            _context.HundeData.Add(hundeData);

            await _context.SaveChangesAsync();


            return await GetAllHunde();
        }


        [HttpPut("{Id}")]
        public async Task<ActionResult<List<HundeData>>> UpdateHunde(int Id, HundeData hundeData)
        {

            var dbHundeData = await _context.HundeData.FindAsync(Id);
            if(dbHundeData == null)
            {
                return NotFound("Hunden med dette ID findes ikke");
            }

            dbHundeData.HundeNavn = hundeData.HundeNavn;
            dbHundeData.FCIGrupper = hundeData.FCIGrupper;
            dbHundeData.HundeStørrelse = hundeData.HundeStørrelse;
            dbHundeData.HundeTemperament = hundeData.HundeTemperament;
            dbHundeData.HundePelspleje = hundeData.HundePelspleje;
            dbHundeData.HundeEnergi = hundeData.HundeEnergi;
            //dbHundeData.HundeBeskrivelsen = hundeData.HundeBeskrivelsen;

            await _context.SaveChangesAsync();


            return await GetAllHunde();
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<HundeData>>> DeleteHunde(int Id)
        {

            var dbHundeData = await _context.HundeData.FindAsync(Id);
            if (dbHundeData == null)
            {
                return NotFound("Hunden med dette ID findes ikke");
            }

            _context.HundeData.Remove(dbHundeData);

            await _context.SaveChangesAsync();


            return await GetAllHunde();
        }

    }
}
