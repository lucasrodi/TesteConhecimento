import { GetFilme } from "../../Api/ApiGet";
import "../index.css"
import "./GetFilmes.css"
import { Filme } from "../../Models/Filme";
export function BuscarFilme() {
    const { data: repositorio } = GetFilme<Filme[]>("sda");

    return (
        <div className="container">
            <h1 className="titulo__Buscar--Filme">Filme</h1>
            <form>
                <label className="label" htmlFor="Nome">Digite o nome do filme</label>
                <input className="input" id="Nome" type="text" name="NomeFilme" placeholder="Digite o nome aqui" />
                <input className="buscar" type="submit" name="Buscar" value="Buscar" />
            </form>
            {repositorio?.map(repo => {
                return (<>
                    <p>{repo.Nome}</p>
                    <p>{repo.Duracao}</p>
                    <p>{repo.Genero}</p>
                </>
                );

            })}

        </div>

    );
}