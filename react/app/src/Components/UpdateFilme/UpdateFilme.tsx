import "../index.css"
import "../AddFilme/AddFilme.css"
import { useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import Api from "../../Api/Api";
export function UpdateFilme() {
    const [nome, setNome] = useState("")
    const [duracao, setDuracao] = useState("")
    const [genero, setGenero] = useState("")
    let { id } = useParams();
    let navigate = useNavigate()
    const PutFilme = async (e: any) => {
        e.preventDefault()
        try {
            await Api.put(`UpdateFilme?id=${id?.replace("id=", "")}&nome=${nome}&duracao=${duracao}&genero=${genero}`)
            setNome("")
            setGenero("")
            setDuracao("")
            navigate("/")
        } catch (error) {
            console.log(error)
        }
    }

    return (

        <div className="container">
            <h1 className="titulo">Atualizar Filme</h1>
            <form className="form">
                <label className="label" htmlFor="nome">Nome do filme</label>
                <input
                    className="input"
                    id="nome" type="text"
                    name="Nome"
                    placeholder="Digite o nome do filme"
                    value={nome} onChange={(e) => { setNome(e.target.value) }}
                />
                <label className="label" htmlFor="duracao">Duracão do filme</label>
                <input
                    className="input"
                    id="duracao"
                    type="text"
                    name="duracao"
                    placeholder="Digite o duracão do filme"
                    value={duracao} onChange={(e) => { setDuracao(e.target.value) }}
                />
                <label className="label" htmlFor="genero">Gênero do filme</label>
                <input
                    className="input"
                    id="genero"
                    type="text"
                    name="genero"
                    placeholder="Digite o gênero do filme"
                    value={genero} onChange={(e) => { setGenero(e.target.value) }}
                />
                <button
                    className="button"
                    onClick={PutFilme}
                >
                    Adicionar
                </button>
            </form>
        </div>
    );
}



