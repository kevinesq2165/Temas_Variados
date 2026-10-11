use problema1_productos;

-- 1) Inyección clásica: condición siempre verdadera
SELECT * FROM productos WHERE nombre = '' OR '1'='1';

-- 2) Inyección basada en tiempo: la consulta se demora 15 segundos
SELECT * FROM productos WHERE id = 1 AND SLEEP(15);

-- 3) Inyección con comentario: anula el resto de la consulta
SELECT * FROM productos WHERE nombre = 'Producto' OR 1=1; -- productos