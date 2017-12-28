using DMS.API.Core.Dtos;
using DMS.API.Core.Models;
using DMS.API.Persistence;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace DMS.API.Controllers.API
{
    public class MetersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Meters
        public IEnumerable<MeterDto> GetMeters()
        {
            var dto = db.Meters
                .Include(d => d.DMZ)
                .Include(c => c.City)
                .Include(p => p.MeterProtocol)
                .Include(t => t.MeterType)
                .Include(s => s.MeterSize)
                .Select(m => new MeterDto()
                {
                   SerialNumber = m.SerialNumber,
                   X = m.X,
                   Y = m.Y,
                   Status = m.Status,
                   HCN = m.HCN,
                   InstallationDate = m.InstallationDate,
                   MaintenanceDate = m.MaintenanceDate,
                   MeterType = m.MeterType.TypeDescription,
                   MeterProtocol = m.MeterProtocol.ProtocolDescription,
                   MeterSize = m.MeterSize.SizeDescription,
                   DMZ = m.DMZ.DMZDescription,
                   City = m.City.CityDescription
                });

            return dto;
        }

        // GET: api/Meters/5
        [ResponseType(typeof(Meter))]
        public async Task<IHttpActionResult> GetMeter(string id)
        {
            var meter = await db.Meters
                        .Include(d => d.DMZ)
                        .Include(c => c.City)
                        .Include(p => p.MeterProtocol)
                        .Include(t => t.MeterType)
                        .Include(s => s.MeterSize)
                        .Select(m => new MeterDto()
                        {
                           SerialNumber = m.SerialNumber,
                           X = m.X,
                           Y = m.Y,
                           Status = m.Status,
                           HCN = m.HCN,
                           InstallationDate = m.InstallationDate,
                           MaintenanceDate = m.MaintenanceDate,
                           MeterType = m.MeterType.TypeDescription,
                           MeterProtocol = m.MeterProtocol.ProtocolDescription,
                           MeterSize = m.MeterSize.SizeDescription,
                           DMZ = m.DMZ.DMZDescription,
                           City = m.City.CityDescription
                        }).FirstAsync(x => x.SerialNumber == id);
                                
            if (meter == null)
            {
                return NotFound();
            }

            return Ok(meter);
        }

        // PUT: api/Meters/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMeter(string id, Meter meter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != meter.SerialNumber)
            {
                return BadRequest();
            }

            db.Entry(meter).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeterExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Meters
        [ResponseType(typeof(Meter))]
        public async Task<IHttpActionResult> PostMeter(Meter meter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Meters.Add(meter);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MeterExists(meter.SerialNumber))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = meter.SerialNumber }, meter);
        }

        // DELETE: api/Meters/5
        [ResponseType(typeof(Meter))]
        public async Task<IHttpActionResult> DeleteMeter(string id)
        {
            Meter meter = await db.Meters.FindAsync(id);
            if (meter == null)
            {
                return NotFound();
            }

            db.Meters.Remove(meter);
            await db.SaveChangesAsync();

            return Ok(meter);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MeterExists(string id)
        {
            return db.Meters.Count(e => e.SerialNumber == id) > 0;
        }
    }
}