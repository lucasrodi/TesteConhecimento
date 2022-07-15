import { useState } from "react";
import { PostFilme } from "../../Api/ApiPost";
import { Filme } from "../../Models/Filme";
import "../index.css"
import "./AddFilme.css"
export function AddFilme() {
    const [nome, setNome] = useState("");
    const [duracao, setDuracao] = useState("");
    const [genero, setGenero] = useState("");
    const [url, setUrl] = useState("");
    PostFilme<Filme>(url)
    return (
        <div className="container">
            <h1 className="titulo">Adicionar Filme</h1>
            <form className="form" >
                <label className="label" htmlFor="nome">Nome do filme</label>
                <input
                    required
                    className="input"
                    id="nome" type="text"
                    name="Nome"
                    placeholder="Digite o nome do filme"
                    value={nome} onChange={(e) => { setNome(e.target.value) }}
                />
                <label className="label" htmlFor="duracao">Duracão do filme</label>
                <input
                    required
                    className="input"
                    id="duracao"
                    type="text"
                    name="duracao"
                    placeholder="Digite o duracão do filme"
                    value={duracao} onChange={(e) => { setDuracao(e.target.value) }}
                />
                <label className="label" htmlFor="genero">Gênero do filme</label>
                <input
                    required
                    className="input"
                    id="genero"
                    type="text"
                    name="genero"
                    placeholder="Digite o gênero do filme"
                    value={genero} onChange={(e) => { setGenero(e.target.value) }}
                />
                <button onClick={(e) => {
                    e.preventDefault()
                    setUrl(`https://localhost:7241/Api/Filme/AddFilme?nome=${nome}&duracao=${duracao}&genero=${genero}`)
                }} className="button" >Adicionar</button>
            </form>

        </div>
    );
}

