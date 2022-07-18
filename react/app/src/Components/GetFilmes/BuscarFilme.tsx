import "../index.css"
import "./GetFilmes.css"
import { useState } from "react";
import Api from "../../Api/Api";
import { Filme } from "../../Models/Filme";
export function BuscarFilme() {
    const [id, setId] = useState("");
    const [filme, setFilme] = useState<Filme>()
    const GetFilmes = async () => {
        try {
            const response = await Api.get(`/FilmeId?id=${id}`)
            setFilme(response.data)
        } catch (error) {
            console.log(error)
        }
    }
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
                        GetFilmes()
                    }}
                    className="buscar"
                    type="submit" name="Buscar"
                    value="Buscar"> Buscar
                </button>
            </form>


            <p>{filme?.nome}</p>
            <p>{filme?.duracao}</p>
            <p>{filme?.genero}</p>


        </div>
    );
}