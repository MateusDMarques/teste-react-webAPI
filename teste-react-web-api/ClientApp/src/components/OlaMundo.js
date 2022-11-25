import {useState} from "react";
import axios from './';

const OlaMundo = () => {
  const [dados,setDados] = useState(null);

  if (dados === null) {
    axios.get('/api/aluno')
      .then(resp => {
        setDados(resp.data)
      })
    return <div>Carregando...</div>
  }else{

  }
}

export default OlaMundo;