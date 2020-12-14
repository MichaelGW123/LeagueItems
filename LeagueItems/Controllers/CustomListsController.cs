using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeagueItems.Models;

namespace LeagueItems.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomListsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CustomLists
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<CustomList>>> GetCustomList()
        //{
        //    return await _context.CustomList.ToListAsync();
        //}

        public ActionResult<List<ViewCustomList>> GetCustomList()
        {
            var tempCustomList = _context.CustomList.ToList();
            var tempEquipment = _context.Equipment.ToList();
            var tempChampions = _context.Champion.ToList();
            var TempEquipmentName1 = (string)null;
            var TempEquipmentName2 = (string)null;
            var TempEquipmentName3 = (string)null;
            var TempEquipmentName4 = (string)null;
            var TempEquipmentName5 = (string)null;
            var TempEquipmentName6 = (string)null;
            var customLists = new List<ViewCustomList>();
            foreach (var custList in tempCustomList)
            {
                if (custList.EquipmentId1 != null)
                {
                    TempEquipmentName1 = tempEquipment.Where(Equipment => custList.EquipmentId1 == Equipment.EquipmentId).FirstOrDefault().Name;
                }
                if (custList.EquipmentId2 != null)
                {
                    TempEquipmentName2 = tempEquipment.Where(Equipment => custList.EquipmentId2 == Equipment.EquipmentId).FirstOrDefault().Name;
                }
                if (custList.EquipmentId3 != null)
                {
                    TempEquipmentName3 = tempEquipment.Where(Equipment => custList.EquipmentId3 == Equipment.EquipmentId).FirstOrDefault().Name;
                }
                if (custList.EquipmentId4 != null)
                {
                    TempEquipmentName4 = tempEquipment.Where(Equipment => custList.EquipmentId4 == Equipment.EquipmentId).FirstOrDefault().Name;
                }
                if (custList.EquipmentId5 != null)
                {
                    TempEquipmentName5 = tempEquipment.Where(Equipment => custList.EquipmentId5 == Equipment.EquipmentId).FirstOrDefault().Name;
                }
                if (custList.EquipmentId6 != null)
                {
                    TempEquipmentName6 = tempEquipment.Where(Equipment => custList.EquipmentId6 == Equipment.EquipmentId).FirstOrDefault().Name;
                }
                ViewCustomList temp = new ViewCustomList
                {
                    ListId = custList.ListId,
                    Name = custList.Name,
                    ChampionName = tempChampions.Where(Champion => custList.ChampionId == Champion.ChampionId).FirstOrDefault().Name,
                    EquipmentName1 = TempEquipmentName1,
                    EquipmentName2 = TempEquipmentName2,
                    EquipmentName3 = TempEquipmentName3,
                    EquipmentName4 = TempEquipmentName4,
                    EquipmentName5 = TempEquipmentName5,
                    EquipmentName6 = TempEquipmentName6,
                };
                customLists.Add(temp);
                TempEquipmentName1 = (string)null;
                TempEquipmentName2 = (string)null;
                TempEquipmentName3 = (string)null;
                TempEquipmentName4 = (string)null;
                TempEquipmentName5 = (string)null;
                TempEquipmentName6 = (string)null;
            };
            return customLists;
        }


        // GET: api/CustomLists/5
        [HttpGet("{id}")]
        //public async Task<ActionResult<CustomList>> GetCustomList(int id)
        //{
        //    var customList = await _context.CustomList.FindAsync(id);

        //    if (customList == null)
        //    {
        //        return NotFound();
        //    }

        //    return customList;
        //}
        public async Task<ActionResult<ViewCustomList>> GetCustomList(int id)
        {
            var customList = await _context.CustomList.FindAsync(id);

            if (customList == null)
            {
                return NotFound();
            }
            var tempEquipment = _context.Equipment.ToList();
            var tempChampions = _context.Champion.ToList();
            var TempEquipmentName1 = (string)null;
            var TempEquipmentName2 = (string)null;
            var TempEquipmentName3 = (string)null;
            var TempEquipmentName4 = (string)null;
            var TempEquipmentName5 = (string)null;
            var TempEquipmentName6 = (string)null;
            if (customList.EquipmentId1 != null)
            {
                TempEquipmentName1 = tempEquipment.Where(Equipment => customList.EquipmentId1 == Equipment.EquipmentId).FirstOrDefault().Name;
            } else
            {
                TempEquipmentName1 = "None";
            }
            if (customList.EquipmentId2 != null)
            {
                TempEquipmentName2 = tempEquipment.Where(Equipment => customList.EquipmentId2 == Equipment.EquipmentId).FirstOrDefault().Name;
            }
            else
            {
                TempEquipmentName2 = "None";
            }
            if (customList.EquipmentId3 != null)
            {
                TempEquipmentName3 = tempEquipment.Where(Equipment => customList.EquipmentId3 == Equipment.EquipmentId).FirstOrDefault().Name;
            }
            else
            {
                TempEquipmentName3 = "None";
            }
            if (customList.EquipmentId4 != null)
            {
                TempEquipmentName4 = tempEquipment.Where(Equipment => customList.EquipmentId4 == Equipment.EquipmentId).FirstOrDefault().Name;
            }
            else
            {
                TempEquipmentName4 = "None";
            }
            if (customList.EquipmentId5 != null)
            {
                TempEquipmentName5 = tempEquipment.Where(Equipment => customList.EquipmentId5 == Equipment.EquipmentId).FirstOrDefault().Name;
            }
            else
            {
                TempEquipmentName5 = "None";
            }
            if (customList.EquipmentId6 != null)
            {
                TempEquipmentName6 = tempEquipment.Where(Equipment => customList.EquipmentId6 == Equipment.EquipmentId).FirstOrDefault().Name;
            }
            else
            {
                TempEquipmentName6 = "None";
            }
            ViewCustomList ViewModel = new ViewCustomList
            {
                ListId = customList.ListId,
                Name = customList.Name,
                ChampionName = tempChampions.Where(Champion => customList.ChampionId == Champion.ChampionId).FirstOrDefault().Name,
                EquipmentName1 = TempEquipmentName1,
                EquipmentName2 = TempEquipmentName2,
                EquipmentName3 = TempEquipmentName3,
                EquipmentName4 = TempEquipmentName4,
                EquipmentName5 = TempEquipmentName5,
                EquipmentName6 = TempEquipmentName6,
            };

            return ViewModel;
        }

        // PUT: api/CustomLists/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomList(int id, ViewCustomList viewModel)
        {
            if (id != viewModel.ListId)
            {
                return BadRequest();
            }

            var tempEquipment = _context.Equipment.ToList();
            var championId = _context.Champion.Where(champion => champion.Name == viewModel.ChampionName).FirstOrDefault().ChampionId;
            Nullable<int> tempE1Id = 0;
            Nullable<int> tempE2Id = 0;
            Nullable<int> tempE3Id = 0;
            Nullable<int> tempE4Id = 0;
            Nullable<int> tempE5Id = 0;
            Nullable<int> tempE6Id = 0;
            if (viewModel.EquipmentName1.Length != 0 && tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName1).FirstOrDefault() != null)
            {
                tempE1Id = tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName1).FirstOrDefault().EquipmentId;
            }
            else
            {
                tempE1Id = null;
            }
            if (viewModel.EquipmentName2.Length != 0 && tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName2).FirstOrDefault() != null)
            {
                tempE2Id = tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName2).FirstOrDefault().EquipmentId;
            }
            else
            {
                tempE2Id = null;
            }
            if (viewModel.EquipmentName3.Length != 0 && tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName3).FirstOrDefault() != null)
            {
                tempE3Id = tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName3).FirstOrDefault().EquipmentId;
            }
            else
            {
                tempE3Id = null;
            }
            if (viewModel.EquipmentName4.Length != 0 && tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName4).FirstOrDefault() != null)
            {
                tempE4Id = tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName4).FirstOrDefault().EquipmentId;
            }
            else
            {
                tempE4Id = null;
            }
            if (viewModel.EquipmentName5.Length != 0 && tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName5).FirstOrDefault() != null)
            {
                tempE5Id = tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName5).FirstOrDefault().EquipmentId;
            }
            else
            {
                tempE5Id = null;
            }
            if (viewModel.EquipmentName6.Length != 0 && tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName6).FirstOrDefault() != null)
            {
                tempE6Id = tempEquipment.Where(equipment => equipment.Name == viewModel.EquipmentName6).FirstOrDefault().EquipmentId;
            }
            else
            {
                tempE6Id = null;
            }

            CustomList customList = new CustomList
            {
                ListId = viewModel.ListId,
                Name = viewModel.Name,
                UserId = "50",
                ChampionId = championId,
                EquipmentId1 = tempE1Id,
                EquipmentId2 = tempE2Id,
                EquipmentId3 = tempE3Id,
                EquipmentId4 = tempE4Id,
                EquipmentId5 = tempE5Id,
                EquipmentId6 = tempE6Id
            };

            _context.Entry(customList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomListExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CustomLists
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CustomList>> PostCustomList(CreateCustomListView viewModel)
        {
            var champion = (from c in _context.Champion
                           where c.Name == viewModel.ChampionName
                           select new CustomList
                           {
                               Name = viewModel.Name,
                               UserId = viewModel.UserId,
                               ChampionId = c.ChampionId,
                           }).Single();
            CustomList customList = new CustomList();
            customList = champion;
            _context.CustomList.Add(customList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomList", new { id = customList.ListId }, customList);
        }
         
        // DELETE: api/CustomLists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CustomList>> DeleteCustomList(int id)
        {
            var customList = await _context.CustomList.FindAsync(id);
            if (customList == null)
            {
                return NotFound();
            }

            _context.CustomList.Remove(customList);
            await _context.SaveChangesAsync();

            return customList;
        }

        private bool CustomListExists(int id)
        {
            return _context.CustomList.Any(e => e.ListId == id);
        }
    }
}
