import "../index.css"
import "../AddFilme/AddFilme.css"
export function UpdateFilme() {
    return (

        <div className="container">
            <h1 className="titulo">Atualizar Filme</h1>
            <form className="form">
                <label className="label" htmlFor="nome">Nome do filme</label>
                <input className="input" id="nome" type="text" name="Nome" placeholder="Digite o nome do filme" />
                <label className="label" htmlFor="duracao">Duracão do filme</label>
                <input className="input" id="duracao" type="text" name="duracao" placeholder="Digite o duracão do filme" />
                <label className="label" htmlFor="genero">Gênero do filme</label>
                <input className="input" id="genero" type="text" name="genero" placeholder="Digite o gênero do filme" />
                <button className="button" >Adicionar</button>
            </form>
        </div>
    );
}