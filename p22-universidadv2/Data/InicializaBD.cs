using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using p21_universidadv1.Modelo;

namespace p21_universidadv1.Data
{
    public class InicializaBD {
        public static void Inicializar(UniContexto contexto) {
            contexto.Database.EnsureCreated();

            if(contexto.Estudiantes.Any()) {
                return; // que la bd ya tiene datos
            }
            // Agregar estudiantes
            var estudiantes = new Estudiante[] {
                new Estudiante {Apaterno="Briones",Amaterno="Escobedo",Nombre="Jose Antonio",email="jonas98@hotmail.com",FechadeIngreso=DateTime.Parse("2020-09-01")},
                new Estudiante {Apaterno="Hinojoza",Amaterno="Hernandez",Nombre="Oscar",email="hinoher@gmail.com",FechadeIngreso=DateTime.Parse("2021-05-20")},
                new Estudiante {Apaterno="Lopez",Amaterno="Rocha",Nombre="Jose Antonio",email="jonas98@hotmail.com",FechadeIngreso=DateTime.Parse("2021-05-20")},
                new Estudiante {Apaterno="Mijares",Amaterno="Ochoa",Nombre="Pedro",email="34116632@uaz.edu.mx",FechadeIngreso=DateTime.Parse("2010-04-20")},
                new Estudiante {Apaterno="Ramirez",Amaterno="Gallardo",Nombre="Jose Martin",email="raipper111@gmail.com",FechadeIngreso=DateTime.Parse("2018-03-15")},
                new Estudiante {Apaterno="Aguayo",Amaterno="Alvarado",Nombre="Edgar",email="elaguayo@hotmail.com",FechadeIngreso=DateTime.Parse("2019-02-11")},
                new Estudiante {Apaterno="Herrara",Amaterno="Herrera",Nombre="Teresa",email="tere25@gmail.com",FechadeIngreso=DateTime.Parse("2015-06-18")},
                new Estudiante {Apaterno="Pacheco",Amaterno="Lamas",Nombre="Esmeralda",email="esmepacheco19@hotmail.com",FechadeIngreso=DateTime.Parse("2021-08-10")}
            };
            foreach (Estudiante e in estudiantes) contexto.Estudiantes.Add(e);
            contexto.SaveChanges();
            // Agregar instructores
            var instructores = new Instructor[] {
                new Instructor {Apaterno="Castaneda",Amaterno="Ramirez",Nombre="Carlos",email="castr@uaz.edu.mx",FechaContratacion=DateTime.Parse("1998-10-01")},
                new Instructor {Apaterno="Villa",Amaterno="Cisneros",Nombre="Juan Luis",email="jlvilla@uaz.edu.mx",FechaContratacion=DateTime.Parse("2003-10-01")},
                new Instructor {Apaterno="Cordova",Amaterno="Lara",Nombre="Gabriela",email="icegaby@uaz.edu.mx",FechaContratacion=DateTime.Parse("2005-10-1")},
                new Instructor {Apaterno="Ramirez",Amaterno="Aguilera",Nombre="Atziry",email="atziry@uaz.edu.mx",FechaContratacion=DateTime.Parse("2007-10-01")},
                new Instructor {Apaterno="Vazquez",Amaterno="Reyes",Nombre="Sodel",email="sodelvr@uaz.edu.mx",FechaContratacion=DateTime.Parse("2007-10-01")}
            };
            foreach (Instructor i in instructores) contexto.Instructores.Add(i);
            contexto.SaveChanges();
            // Agregar departamentos
            var departamentos = new Departamento[]  {
                new Departamento {Nombre="Ingles",Presupuesto=35000,Fechadenicio=DateTime.Parse("2007-09-01")},
                new Departamento {Nombre="Matematicas",Presupuesto=135000,Fechadenicio=DateTime.Parse("2007-09-01")},
                new Departamento {Nombre="Ingenieria",Presupuesto=15000,Fechadenicio=DateTime.Parse("2007-09-01")},
                new Departamento {Nombre="Economicas",Presupuesto=10000,Fechadenicio=DateTime.Parse("2007-09-01")},
                new Departamento {Nombre="Computacion",Presupuesto=55000,Fechadenicio=DateTime.Parse("2007-09-01")}
            };
            foreach(Departamento d in departamentos) contexto.Departamentos.Add(d);
            contexto.SaveChanges();
            // Agregar Cursos
            var cursos = new Curso[] {
                new Curso {CursoId=1050,Titulo="Quimica",Creditos=3,DepartamentoId=departamentos.Single(s=> s.Nombre=="Ingenieria").Departamentoid},
                new Curso {CursoId=4022,Titulo="Microeconomia",Creditos=3,DepartamentoId=departamentos.Single(s=> s.Nombre=="Economicas").Departamentoid},
                new Curso {CursoId=4023,Titulo="Macroeconomia",Creditos=3,DepartamentoId=departamentos.Single(s=> s.Nombre=="Economicas").Departamentoid},
                new Curso {CursoId=4041,Titulo="Calculo",Creditos=3,DepartamentoId=departamentos.Single(s=> s.Nombre=="Matematicas").Departamentoid},
                new Curso {CursoId=1045,Titulo="Trigonometria",Creditos=3,DepartamentoId=departamentos.Single(s=> s.Nombre=="Matematicas").Departamentoid},
                new Curso {CursoId=3141,Titulo="Composicion",Creditos=3,DepartamentoId=departamentos.Single(s=> s.Nombre=="Ingles").Departamentoid},
                new Curso {CursoId=2021,Titulo="Literatura",Creditos=3,DepartamentoId=departamentos.Single(s=> s.Nombre=="Ingles").Departamentoid},
                new Curso {CursoId=5022,Titulo="Programacion 1",Creditos=3,DepartamentoId=departamentos.Single(s=> s.Nombre=="Computacion").Departamentoid}
            };
            foreach(Curso c in cursos) contexto.Cursos.Add(c);
            contexto.SaveChanges();
            // Asignar oficina
            var oficinaasignadas = new OficinaAsignada[] {
                new OficinaAsignada {InstructorId=instructores.Single(i=>i.Nombre=="Castaneda").Id, Ubicacion="Cubiculo 3"},
                new OficinaAsignada {InstructorId=instructores.Single(i=>i.Nombre=="Villa").Id, Ubicacion="Cubiculo 5"},
                new OficinaAsignada {InstructorId=instructores.Single(i=>i.Nombre=="Vazquez").Id, Ubicacion="Direccion de IS"}
            };
            foreach(OficinaAsignada o in oficinaasignadas) contexto.OficinaAsignadas.Add(o);
            contexto.SaveChanges();
            // Asignar al instructor sus cursos
            var asingacioncursos = new AsignacionCurso[] {
                new AsignacionCurso {CursoId=cursos.Single(c=>c.Titulo=="Quimica").CursoId,InstructorId=instructores.Single(i=>i.Nombre=="Ramirez").Id},
                new AsignacionCurso {CursoId=cursos.Single(c=>c.Titulo=="Microeconomia").CursoId,InstructorId=instructores.Single(i=>i.Nombre=="Cordova").Id},
                new AsignacionCurso {CursoId=cursos.Single(c=>c.Titulo=="Macroeconomia").CursoId,InstructorId=instructores.Single(i=>i.Nombre=="Cordova").Id},
                new AsignacionCurso {CursoId=cursos.Single(c=>c.Titulo=="Calculo").CursoId,InstructorId=instructores.Single(i=>i.Nombre=="Villa").Id},
                new AsignacionCurso {CursoId=cursos.Single(c=>c.Titulo=="Trigonometria").CursoId,InstructorId=instructores.Single(i=>i.Nombre=="Villa").Id},
                new AsignacionCurso {CursoId=cursos.Single(c=>c.Titulo=="Literatura").CursoId,InstructorId=instructores.Single(i=>i.Nombre=="Vazquez").Id},
                new AsignacionCurso {CursoId=cursos.Single(c=>c.Titulo=="Composicion").CursoId,InstructorId=instructores.Single(i=>i.Nombre=="Vazquez").Id},
                new AsignacionCurso {CursoId=cursos.Single(c=>c.Titulo=="Castaneda").CursoId,InstructorId=instructores.Single(i=>i.Nombre=="Programacion 1").Id},
            };
            foreach(AsignacionCurso ac in asingacioncursos) contexto.AsignacionCursos.Add(ac);
            contexto.SaveChanges();
            // Agregar inscripciones 
            var inscripciones = new Inscripcion[] {
                new Inscripcion { CursoId=cursos.Single(c=>c.Titulo=="Quimica").CursoId, EstudianteId=estudiantes.Single(e=>e.Nombre=="Briones").Id},
                new Inscripcion { CursoId=cursos.Single(c=>c.Titulo=="Calculo").CursoId, EstudianteId=estudiantes.Single(e=>e.Nombre=="Briones").Id},
                new Inscripcion { CursoId=cursos.Single(c=>c.Titulo=="Trigonometria").CursoId, EstudianteId=estudiantes.Single(e=>e.Nombre=="Hinojoza").Id},
                new Inscripcion { CursoId=cursos.Single(c=>c.Titulo=="Microeconomia").CursoId, EstudianteId=estudiantes.Single(e=>e.Nombre=="Hinojoza").Id},
                new Inscripcion { CursoId=cursos.Single(c=>c.Titulo=="Macroeconomia").CursoId, EstudianteId=estudiantes.Single(e=>e.Nombre=="Hinojoza").Id},
                new Inscripcion { CursoId=cursos.Single(c=>c.Titulo=="Quimica").CursoId, EstudianteId=estudiantes.Single(e=>e.Nombre=="Lopez").Id},
                new Inscripcion { CursoId=cursos.Single(c=>c.Titulo=="Programacion 1").CursoId, EstudianteId=estudiantes.Single(e=>e.Nombre=="Lopez").Id},
                new Inscripcion { CursoId=cursos.Single(c=>c.Titulo=="Composicion").CursoId, EstudianteId=estudiantes.Single(e=>e.Nombre=="Mijares").Id},
                new Inscripcion { CursoId=cursos.Single(c=>c.Titulo=="Composicion").CursoId, EstudianteId=estudiantes.Single(e=>e.Nombre=="Ramirez").Id},
                new Inscripcion { CursoId=cursos.Single(c=>c.Titulo=="Composicion").CursoId, EstudianteId=estudiantes.Single(e=>e.Nombre=="Aguayo").Id}
            };
            foreach(Inscripcion ins in inscripciones) {
                var ei = contexto.Inscripciones.Where(s=>s.EstudianteId==ins.EstudianteId && s.CursoId==ins.CursoId).SingleOrDefault();
                if(ei is null) contexto.Inscripciones.Add(ins);
            }
            contexto.SaveChanges();
        }
    }
}