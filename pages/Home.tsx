import React from 'react';
import ConsultaInfo from '../components/ConsultaInfo';
import '../styles/home.css';  // Importe o novo CSS

const Home: React.FC = () => {
  return (
    <div className="home-container">
      <h1>Consulta+</h1>
      <ConsultaInfo />
    </div>
  );
};

export default Home;
