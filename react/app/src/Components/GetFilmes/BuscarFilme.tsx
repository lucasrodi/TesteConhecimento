import { GetFilme } from "../../Api/ApiGet";
import "../index.css"
import "./GetFilmes.css"
import { Filme } from "../../Models/Filme";
import { useState } from "react";
export function BuscarFilme() {
    const [id, setId] = useState("");
    const [url, setUrl] = useState("");
    const { data } = GetFilme<Filme>(url);

    return (
        <div className="container">
            <h1 className="titulo__Buscar--Filme">Filme</h1>
            <form>
                <label className="label" htmlFor="Nome">Digite o id do filme</label>
                <input
                    className="input"
                    id="Nome" type="number"
                    name="NomeFilme"
                    placeholder="Digite o id aqui"
                    value={id} onChange={(e) => { setId(e.target.value) }}
                />
                <button
                    onClick={(e) => {
                        e.preventDefault()
                        setUrl(`https://localhost:7241/Api/Filme/FilmeId?id=${id}`)
                    }}
                    className="buscar"
                    type="submit" name="Buscar"
                    value="Buscar"> Buscar
                </button>
            </form>


            <p>{data?.nome}</p>
            <p>{data?.duracao}</p>
            <p>{data?.genero}</p>




        </div>

    );
}