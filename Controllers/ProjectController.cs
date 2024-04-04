using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data;
using TimesheetAPI.Data;
using System;
using TimesheetAPI.Models;
using System.Linq;


namespace TimesheetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller
    {
        private readonly TimesheetSystemDbContext _context;

        public ProjectController(TimesheetSystemDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getData")]
        public async Task<IActionResult> getData()
        {
            return Ok(await _context.Data.ToListAsync());
        }

        [HttpGet]
        [Route("goalForAll")]
        public async Task<IActionResult> getGoalAll()
        {
            return Ok(await _context.Goals.ToListAsync());
        }

        [HttpGet]
        [Route("setGoal/{xpusercode}")]
        public async Task<IActionResult> setGoal([FromRoute] int xpusercode)
        {
            var item = await _context.Goals
                .Where(p => p.Xpusercode == xpusercode)
                .ToListAsync();
            return Ok(item);
        }

        [HttpGet]
        [Route("getPerPartner/{partner}")]
        public async Task<IActionResult> getPerPartner([FromRoute] int partner)
        {
            var item = await _context.AuaTranstions
                .Where(p => p.SqlpartnerCheck == partner)
                .OrderBy(x => x.Date)
                .ToListAsync();
            return Ok(item);
        }

        [HttpGet]
        [Route("getTransition")]

        public async Task<IActionResult> getTransitionData()
        {
            //ordered by date
            return Ok(await _context.AuaTranstions.OrderBy(x => x.Date).ToListAsync());
        }

        [HttpGet]
        [Route("getPartners")]
        public async Task<IActionResult> getPartners()
        {
            return Ok(await _context.Partners.OrderBy(x => x.PartnerName).ToListAsync());
        }

        [HttpGet]
        [Route("getCompliance/{partner}")]

        public async Task<IActionResult> getCompliance([FromRoute] int partner)
        {
            var item = await _context.ComplianceTables
                .Where(x => x.XpUserCode == partner)
                .ToListAsync();
            return Ok(item);
        }

        [HttpGet]
        [Route("getLodgement/{partner}")]

        public async Task<IActionResult> getLodgement([FromRoute] int partner)
        {
            var item = await _context.Logdements
                .Where(p => p.SqlPartnerCheck == partner)
                .OrderBy(x => x.DateMonth)
                .ToListAsync();
            return Ok(item);
        }

        [HttpGet]
        [Route("getIntergrationStats/{partner}")]

        public async Task<IActionResult> getIntergrationStats([FromRoute] int partner)
        {
            var item = await _context.IntegrationStats
                .Where(p => p.SqlPartnerCheck == partner)
                .OrderBy(p => p.Datedatemonth)
                .ToListAsync();
            return Ok(item);
        }

        [HttpGet]
        [Route("GetUser")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _context.Users.ToListAsync());
        }

    
        [HttpGet]
        [Route("Checkuser/ {email}")]
        public async Task<IActionResult> signin([FromRoute] string email, string password)
        {
            var useremail = await _context.Users.FindAsync(email);
            var userpassword = await _context.Users.FindAsync(password);
            if (useremail == null)
            {
                return Ok("email not found");
            }
            
            return Ok(useremail);
        }

    }
}
