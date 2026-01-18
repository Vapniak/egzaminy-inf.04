import logo from './logo.svg';
import './App.css';
import { useRef, useState } from 'react';
import 'bootstrap/dist/css/bootstrap.css';

function App() {
  var [kursy, setKursy] = useState(["Programowanie w C#", "Angular dla początkujących", "Kurs Django"])

  var imieINazwisko = useRef();
  var numerKursu = useRef();

  function handleSubmit(e) {
    e.preventDefault();

    const imieNazwisko = imieINazwisko.current.value;
    const index = numerKursu.current.value - 1;

    var kurs = "Nieprawidłowy numer kursu";

    if (index >= 0 && index < kursy.length) {
      kurs = kursy[index];
    }


    console.log(imieNazwisko);
    console.log(kurs);
  }
  
  return (
    <div className='container'>
      <h2>Liczba kursów: {kursy.length}</h2>
      <ol>
        {kursy.map((kurs) => {
          return (
            <li key={kurs}>{kurs}</li>
          )
        })}
      </ol>
      <form onSubmit={handleSubmit}>
        <div className="form-group mb-3">
          <label htmlFor='imieNazw'>Imię i nazwisko:</label>
          <input id='imieNazw' type="text" className="form-control" ref={imieINazwisko}/>
        </div>
        <div className="form-group mb-3">
          <label htmlFor='numerKursu'>Numer kursu:</label>
          <input id='numerKursu' type="number" className="form-control" ref={numerKursu}/>
        </div>
        <button type='submit' className='btn btn-primary'>Zapisz do kursu</button>
      </form>
    </div>
  );
}

export default App;
