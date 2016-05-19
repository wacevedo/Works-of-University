select p.nombre, p.fecha_entrega
from proyecto p
where p.fecha_entrega between '1-Jan-2015' and '31-Jan-2015';

select * from proyecto;

select e.nombre, p.nombre
from empresa e, proyecto p
where e.id_empresa=p.id_empresa;


select p.nombre, l.descripcion, count(p.id_proyecto)
from proyecto p, lenguaje l, proyecto_lenguaje pl
where p.id_proyecto=pl.id_proyecto and pl.id_lenguaje=l.id_lenguaje 
group by p.nombre, l.descripcion;


select p.id_proyecto, e.nombre, count(e.id_proyecto)
from etapa e, proyecto p
where p.id_proyecto=e.id_proyecto and e.nombre='Investigacion' or e.nombre='Desarrollo' or e.nombre='Conclusion'
group by p.id_proyecto, e.nombre, p.nombre;

select p.fecha_entrega,p.nombre, pr.nombre
from proyecto p, profesorf pr
where  (p.fecha_entrega>sysdate) and p.id_profesor=pr.id_profesor 
and pr.estado='A';
