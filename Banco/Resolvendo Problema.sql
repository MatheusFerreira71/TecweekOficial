use bdTecweek2;

select P.Codigo, C.CPF, P.Nome, P.DataNasc As DataNascimento, P.Email,
 P.Telefone, E.Nome AS Escolaridade, P.Cod_Escolaridade
From ((TBParticipante as P inner join TB_CPF as C on  P.Cod_CPF = C.Codigo) inner join TBEscolaridade as E
on P.Cod_Escolaridade = E.Codigo);

