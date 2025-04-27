import axios from 'axios';

// Define a estrutura da Consulta
export interface Consulta {
  id: number;
  pacienteId: number;
  medicoId: number;
  paciente: {
    id: number;
    nome: string;
    documento: number;
  };
  medico: {
    id: number;
    nome: string;
    especialidade: string;
  };
}

// Criar instância do axios configurada
const api = axios.create({
  baseURL: 'http://localhost:5028/api/', // URL base da sua API
  headers: {
    'Content-Type': 'application/json', // Cabeçalho indicando que o corpo da requisição é JSON
  },
});

// Função para buscar consulta pelo ID
export const getConsultaById = async (id: number): Promise<Consulta> => {
  try {
    const response = await api.get<Consulta>(`Consultas/${id}`); // Faz a requisição para buscar a consulta pelo ID
    return response.data; // Retorna os dados da consulta
  } catch (error) {
    console.error('Erro ao buscar consulta:', error);
    throw error; // Lança o erro para ser tratado no componente
  }
};
