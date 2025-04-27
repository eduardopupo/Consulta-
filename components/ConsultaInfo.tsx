import React, { useState } from 'react';
import { getConsultaById, Consulta } from '../api/api';
import '../styles/global.css'; // Importando os estilos

const ConsultaInfo: React.FC = () => {
  const [consulta, setConsulta] = useState<Consulta | null>(null);
  const [consultaId, setConsultaId] = useState<number>(0); // Estado para armazenar o ID da consulta
  const [loading, setLoading] = useState<boolean>(false); // Estado para controlar o carregamento

  const buscarConsulta = async () => {
    if (consultaId <= 0) {
      alert('Por favor, insira um ID válido.');
      return;
    }
    setLoading(true); // Inicia o carregamento

    try {
      const resposta = await getConsultaById(consultaId); // Chama a API para buscar a consulta
      setConsulta(resposta); // Armazena os dados da consulta
    } catch (error) {
      console.error('Erro ao buscar consulta:', error);
      alert('Erro ao buscar a consulta.');
    } finally {
      setLoading(false); // Finaliza o carregamento
    }
  };

  return (
    <div className="container">
      <h1>Consulta Detalhada</h1>
      
      {/* Campo para o usuário inserir o ID da consulta */}
      <input
        type="number"
        value={consultaId}
        onChange={(e) => setConsultaId(Number(e.target.value))}
        placeholder="Digite o ID da consulta"
      />
      <button onClick={buscarConsulta}>Buscar Consulta</button>

      {/* Exibe uma mensagem de carregamento enquanto busca os dados */}
      {loading && <p className="loading">Carregando...</p>}

      {/* Exibe os dados da consulta quando encontrados */}
      {consulta && !loading && (
        <div className="result">
          <h2>Consulta #{consulta.id}</h2>
          <p><strong>Paciente:</strong> {consulta.paciente.nome}</p>
          <p><strong>Documento:</strong> {consulta.paciente.documento}</p>
          <p><strong>Médico:</strong> {consulta.medico.nome}</p>
          <p><strong>Especialidade:</strong> {consulta.medico.especialidade}</p>
        </div>
      )}
    </div>
  );
};

export default ConsultaInfo;
