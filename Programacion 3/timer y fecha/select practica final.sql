/*Cuantos estudiante tiene cada proyecto*/
select p.Nombre, count(e.ID_ESTUDIANTE)
FROM ESTUDIANTE e, PROYECTO p
WHERE p.id_proyecto = e.id_proyecto
GROUP BY p.NOMBRE;
/*proyectos pendiente*/
select nombre,fecha_entrega
FROM PROYECTO
WHERE (SYSDATE<fecha_entrega);

/*cuantos proyectos tiene un profesor*/
select pr.nombre, pr.APELLIDO, count (p.ID_PROYECTO)
FROM PROYECTO p, PROFESORF pr
where p.id_profesor=pr.id_profesor
group by pr.nombre, pr.apellido;

/*proyectos con mas e tres estudiantes*/

select cantidad_estud, nombre
from proyecto
where cantidad_estud>3;
/*lenguajes de programacion mas usados*/

select l.descripcion, count(l.id_lenguaje)
from LENGUAJE l, PROYECTO p, proyecto_lenguaje pl
where l.id_lenguaje=pl.id_lenguaje and pl.id_proyecto=p.id_proyecto
group by l.descripcion;

/*tipo de proyectos mas  usados*/

select tipo_proyecto, count(id_proyecto)
from proyecto
group  by tipo_proyecto;

/*controlar tiempo de entrega de proyecto*/
select p.fecha_entrega, p.nombre
from proyecto p
order by p.fecha_entrega;

/*empresas, proyectos*/

select e.id_empresa, e.nombre, p.nombre
from empresa e, proyecto p
where e.id_empresa=p.id_empresa; 

/*proyectos demorados*/
select nombre, estado, fecha_entrega 
from proyecto
where (estado='Proceso' or estado='Pendiente') 
and (sysdate>fecha_entrega);
/*etapa de proyecto*/
select p.nombre,e.nombre, e.fecha_final
from etapa e, proyecto p
where (e.id_proyecto=p.id_proyecto)
and (sysdate>=e.fecha_inicio and sysdate<=e.fecha_final);

/*proyecto asignado anteriormente*/

select e.nombre, p.nombre
from estudiante e, proyecto p
where not exists(select p.id_proyecto
from proyecto p
where e.id_proyecto=e.id_proyecto )
group by e.nombre, p.nombre;
/*muestra cantidad de estudiantes por proyecto*/
select p.nombre, count(e.id_estudiante)
from estudiante e, proyecto p
where p.id_proyecto = e.id_proyecto
group by p.nombre;



