No primeiro momento, iria criar apenas 2 tabelas: promoção e produto. Porém, percebi que iria ficar dificil o cotrole das promoções no carrinho se caso o usuário fosse aumentando a quantidade iria ativar uma promoção por exemplo.

Em um segundo momento, conclui que seria mais inteligente criar uma tabela mediadora que buscasse as "regras da promoção" como a qtd e valor e fossem criados "kits" de um único produto a partir das regras. Sendo assim possível isolar as tabelas e fazer cálculos de economia de custos, etc. Além disso, tomei a precaução de tornar a pk dessa tabela mediadora como as outras chaves das tabelas, sendo impossível adicionar mais de uma promoção a um produto.

Meu foco não foi o design nem regras de data anotations em campos, mas sim a ideia (já que o exercicio cita que é um protótipo). Logo, deixei nesse código abertas as possibilidades de implentar algo na lógica relacional acima e, claro, realizando melhorias como uso de cookies, bootstrap, login com facebook, etc.

Grato!
