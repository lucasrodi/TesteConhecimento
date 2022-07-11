import React from 'react';
import './App.css';
import { Routes, Route } from "react-router-dom";
import { PaginaInicial } from "./Components/PaginaInicial"
import { GetAll } from './Components/GetFilmes/GetAll';
import { BuscarFilme } from './Components/GetFilmes/BuscarFilme';
import { AddFilme } from './Components/AddFilme/AddFilme';
import { UpdateFilme } from './Components/UpdateFilme/UpdateFilme';

function App() {
  return (
    <Routes>
      <Route path='/' element={<PaginaInicial />} />
      <Route path='TodosOsFilmes' element={<GetAll />} />
      <Route path='BuscarFilme' element={<BuscarFilme />} />
      <Route path='AdicionarFilme' element={<AddFilme />} />
      <Route path='AtualizarFilme' element={<UpdateFilme />} />
    </Routes>
  );
}

export default App;
