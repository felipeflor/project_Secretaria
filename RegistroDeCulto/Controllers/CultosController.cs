using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RegistroDeCulto.Data;
using RegistroDeCulto.Models;

namespace RegistroDeCulto.Controllers
{
    public class CultosController : Controller
    {
        private readonly RegistroDbContext _context;

        public CultosController(RegistroDbContext context)
        {
            _context = context;
        }

        public IActionResult Unidades()
        {
            return View();
        }

        public IActionResult QuemSomos()
        {
            return View();
        }



        // GET: Cultos
        public async Task<IActionResult> Index()
        {
              return View(await _context.Culto.ToListAsync());
        }

        // GET: Cultos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Culto == null)
            {
                return NotFound();
            }

            var culto = await _context.Culto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (culto == null)
            {
                return NotFound();
            }

            return View(culto);
        }

        // GET: Cultos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cultos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Inicio,Fim,PalavraInicial,HinosHarpa,OracaoOportunidades,Oportunidades,LouvorOfertas,OracaoOfertas,OracaoPreleitor,Preleitor,Mensagem,Adultos,Criancas,Total,Avisos,OracaoFinal,BencaoApostolica")] Culto culto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(culto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(culto);
        }

        // GET: Cultos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Culto == null)
            {
                return NotFound();
            }

            var culto = await _context.Culto.FindAsync(id);
            if (culto == null)
            {
                return NotFound();
            }
            return View(culto);
        }

        // POST: Cultos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Inicio,Fim,PalavraInicial,HinosHarpa,OracaoOportunidades,Oportunidades,LouvorOfertas,OracaoOfertas,OracaoPreleitor,Preleitor,Mensagem,Adultos,Criancas,Total,Avisos,OracaoFinal,BencaoApostolica")] Culto culto)
        {
            if (id != culto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(culto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CultoExists(culto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(culto);
        }

        // GET: Cultos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Culto == null)
            {
                return NotFound();
            }

            var culto = await _context.Culto
                .FirstOrDefaultAsync(m => m.Id == id);
            if (culto == null)
            {
                return NotFound();
            }

            return View(culto);
        }

        // POST: Cultos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Culto == null)
            {
                return Problem("Entity set 'RegistroDbContext.Culto'  is null.");
            }
            var culto = await _context.Culto.FindAsync(id);
            if (culto != null)
            {
                _context.Culto.Remove(culto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CultoExists(int id)
        {
          return _context.Culto.Any(e => e.Id == id);
        }
    }
}
