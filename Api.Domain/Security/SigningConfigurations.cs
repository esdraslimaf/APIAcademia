using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace Api.Application.Security
{
    public class SigningConfigurations
    {
        public SecurityKey Key { get; set; }
        public SigningCredentials SigningCredentials { get; set; }

        public SigningConfigurations()
        {
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                Key = new RsaSecurityKey(provider.ExportParameters(true)); //Key é a chave privada gerada
            }
            SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);
        }

    }
}

/* using (var provider = new RSACryptoServiceProvider(2048)): Um novo objeto RSACryptoServiceProvider é criado com um tamanho de chave de 2048 bits. Este objeto é responsável por gerar uma nova chave RSA aleatória.

Key = new RsaSecurityKey(provider.ExportParameters(true));: A chave RSA recém-criada é então exportada como um conjunto de parâmetros, que inclui tanto a chave pública quanto a chave privada (porque o argumento é true). Esses parâmetros são usados para criar uma nova RsaSecurityKey, que é armazenada na propriedade Key.

SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);: Finalmente, um novo objeto SigningCredentials é criado usando a chave RSA e o algoritmo de assinatura RSA-SHA256. Este objeto é armazenado na propriedade SigningCredentials e será usado para assinar os tokens. 

A chave privada não é salva em nenhum local específico no código, mas é mantida na memória enquanto o objeto SigningConfigurations existir. É importante notar que a chave privada deve ser mantida segura para garantir a segurança do sistema. Se a chave privada for comprometida, qualquer pessoa com acesso a ela poderá descriptografar e possivelmente alterar os tokens 

Quando um novo objeto SigningCredentials é criado, ele recebe a chave RSA (o primeiro parâmetro - Chave Pública e Privada) e o algoritmo de assinatura RSA-SHA256 (o segundo parâmetro). Isso significa que os tokens serão assinados usando a chave RSA e o algoritmo RSA-SHA256.

 o código SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);, o primeiro parâmetro, Key, é a chave que pode ser uma chave pública e privada. Esta chave será usada para assinar os tokens.

O segundo parâmetro, SecurityAlgorithms.RsaSha256Signature, é o algoritmo de assinatura que será usado. Neste caso, indica que o algoritmo RSA-SHA256 será usado. Portanto, é uma maneira de dizer que a chave será usada para criar uma assinatura digital usando o algoritmo de criptografia RSA-SHA256.
 
 */


/* Imagine que você quer enviar uma mensagem secreta para um amigo. Você poderia colocar essa mensagem em uma caixa e trancá-la com um cadeado. A chave que abre esse cadeado é como a chave privada no seu código. Somente quem tem essa chave pode abrir o cadeado e ler a mensagem.

Agora, imagine que você quer provar para o seu amigo que a mensagem realmente veio de você. Você poderia fazer isso assinando a mensagem antes de colocá-la na caixa. A assinatura é como um selo que só pode ser feito por você, e qualquer pessoa que veja a assinatura saberá que a mensagem veio de você.

No seu código, a “mensagem” é o token, a “chave do cadeado” é a chave privada (Key), e a “assinatura” é criada usando a chave privada e o algoritmo RSA-SHA256 (SigningCredentials).

Quando o seu amigo recebe a caixa, ele pode verificar a assinatura para ter certeza de que a mensagem veio de você. Ele faz isso usando a sua chave pública, que é como uma cópia da sua assinatura que ele pode usar para verificar se a assinatura na mensagem é válida. */