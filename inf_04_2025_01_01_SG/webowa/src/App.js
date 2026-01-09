import './App.css';
import 'bootstrap/dist/css/bootstrap.css';
import { useEffect, useState } from 'react';

function App() {
  const [zdjecia, setZdjecia] = useState([
    {id: 0, alt: "Mak", filename: "obraz1.jpg", category:1, downloads: 35},
    {id: 1, alt:"Bukiet", filename: "obraz2.jpg", category: 1, downloads: 43},
    {id: 2, alt:"Dalmatyńczyk", filename: "obraz3.jpg", category:2, downloads: 2},
    {id: 3, alt:"Świnka morska", filename: "obraz4.jpg", category:2, downloads: 53},
    {id: 4, alt:"Rotwailer", filename: "obraz5.jpg", category:2, downloads: 43},
    {id: 5, alt:"Audi", filename: "obraz6.jpg", category:3, downloads: 11},
    {id: 6, alt:"Kotki", filename: "obraz7.jpg", category:2, downloads: 22},
    {id: 7, alt:"Róża", filename: "obraz8.jpg", category:1, downloads: 33},
    {id: 8, alt:"Świnka morska", filename: "obraz9.jpg", category:2, downloads: 123},
    {id: 9, alt:"Foksterier", filename: "obraz10.jpg", category:2, downloads: 22},
    {id: 10, alt:"Szczeniak", filename: "obraz11.jpg", category:2, downloads: 12},
    {id: 11, alt:"Garbus", filename: "obraz12.jpg", category:3, downloads: 321}
  ]);

  const [showKwiaty, setShowKwiaty] = useState(true);
  const [showZwierzęta, setShowZwierzęta] = useState(true);
  const [showSamochody, setShowSamochody] = useState(true);

  const [filtrowane, setFiltrowane] = useState([]);

  useEffect(() => {
    const noweFiltrowane = zdjecia.filter((z) => {
      if (z.category === 1 && showKwiaty) return true;
      if (z.category === 2 && showZwierzęta) return true;
      if (z.category === 3 && showSamochody) return true;
      return false;
    });
    setFiltrowane(noweFiltrowane);
  }, [zdjecia, showKwiaty, showZwierzęta, showSamochody]);

  const handleDownload = (id) => {
    const updatedZdjecia = zdjecia.map((z) => {
      if (z.id === id) return { ...z, downloads: z.downloads + 1 };
      return z;
    });
    setZdjecia(updatedZdjecia);
  };

  return (
    <div className="App" style={{ padding: "20px" }}>
      <h1>Kategorie zdjęć</h1>

      <div style={{ display: "flex"}}>
        <div className="form-check form-switch">
          <input
            className="form-check-input"
            type="checkbox"
            id="kwiaty"
            checked={showKwiaty}
            onChange={() => setShowKwiaty(!showKwiaty)}
          />
          <label className="form-check-label" htmlFor="kwiaty">Kwiaty</label>
        </div>

        <div className="form-check form-switch">
          <input
            className="form-check-input"
            type="checkbox"
            id="zwierzeta"
            checked={showZwierzęta}
            onChange={() => setShowZwierzęta(!showZwierzęta)}
          />
          <label className="form-check-label" htmlFor="zwierzeta">Zwierzęta</label>
        </div>

        <div className="form-check form-switch">
          <input
            className="form-check-input"
            type="checkbox"
            id="samochody"
            checked={showSamochody}
            onChange={() => setShowSamochody(!showSamochody)}
          />
          <label className="form-check-label" htmlFor="samochody">Samochody</label>
        </div>
      </div>

      <div style={{ display: "flex", flexWrap: "wrap"}}>
        {filtrowane.map((z) => (
          <div key={z.id} style={{ margin: "5px"}}>
            <img
              src={"assets/" + z.filename}
              alt={z.alt}
              style={{ borderRadius: "5px", height: "auto" }}
            />
            <h4>Pobrań: {z.downloads}</h4>
            <button
              className="btn btn-success"
              onClick={() => handleDownload(z.id)}
            >
              Pobierz
            </button>
          </div>
        ))}
      </div>
    </div>
  );
}

export default App;
