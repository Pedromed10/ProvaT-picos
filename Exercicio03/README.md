1. Sobrecarga (Overloading):
Sobrecarga ocorre quando uma classe tem vários métodos com o mesmo nome, mas com diferentes parâmetros. Isso permite que métodos com o mesmo nome executem diferentes operações, dependendo dos tipos ou números de parâmetros passados.
Os métodos sobrecarregados devem ter o mesmo nome, mas devem ter assinaturas de parâmetros diferentes (ou seja, tipos de parâmetros diferentes ou números diferentes de parâmetros).
A decisão de qual método sobrecarregado chamar é feita em tempo de compilação, com base nos tipos e números de argumentos passados.

2. Sobreposição (Override):
Sobreposição ocorre quando uma classe derivada redefine um método de sua classe base com a mesma assinatura (nome e tipos de parâmetros) e comportamento diferente.
A sobreposição é usada para fornecer uma implementação específica para um método em uma classe derivada, substituindo a implementação fornecida pela classe base.
A decisão de qual método sobreposto chamar é feita em tempo de execução, com base no tipo real do objeto.

Prompt: "Explique as diferenças entre sobrecarga (overloading) e sobreposição (override) em C#. Em seguida, forneça exemplos de cada um desses conceitos em código. Na explicação, destaque como eles são usados em situações diferentes e como são tratados pelo compilador e em tempo de execução."