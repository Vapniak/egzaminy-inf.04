import logo from './logo.svg';
import './App.css';
import 'bootstrap/dist/css/bootstrap.css';
import { useRef, useState } from 'react';

function App() {
 const tytulRef = useRef();
  const rodzajRef = useRef();

  const handleSubmit = (e) => {
    e.preventDefault();

    const tytul = tytulRef.current.value;
    const rodzaj = rodzajRef.current.value;

    console.log(`tytul: ${tytul}; rodzaj: ${rodzaj}`);
  }

  return (
    <div>
      <form style={{gap: "8px", display: "block"}} onSubmit={handleSubmit}>
        <div className="form-group">
          <label htmlFor="title">Tytuł filmu</label>
          <input type="text" className="form-control" id="title" name='title' ref={tytulRef}/>
        </div>
        <div className="form-group">
          <label htmlFor="rodzaj">Rodzaj</label>
          <select className="form-select" id='rodzaj' name='rodzaj' ref={rodzajRef}>
            <option value={0} selected></option>
            <option value={1}>Komedia</option>
            <option value={2}>Obyczajowy</option>
            <option value={3}>Sensacyjny</option>
            <option value={4}>Horror</option>
          </select>
        </div>
        <button type='submit' className='btn btn-primary'>Dodaj</button>
      </form>
    </div>
  );
}

export default App;
