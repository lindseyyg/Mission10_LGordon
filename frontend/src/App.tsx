import React, { useEffect, useState } from 'react';
import './App.css';
// EDIT OR DELETE
// import bowlerData from './FakeBowlerData.json';
import Header from './Header';
import { BowlerInfo } from './types/BowlerInfo';

// EDIT OR DELETE
// const BowlerData = bowlerData.BowlerData;

function Footer() {
  return <footer>Have a great day! Go bowl a turkey!</footer>;
}

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<BowlerInfo[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5172/bowlerinfo');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <h2>Bowler Information</h2>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.bowlerID}>
              <td>
                {b.bowlerFirstName +
                  ' ' +
                  b.bowlerMiddleInit +
                  ' ' +
                  b.bowlerLastName}
              </td>
              <td>{b.teamName}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

// Parent element, the things inside are the children
function App() {
  return (
    <div className="App">
      <br />
      <Header title="Bowling League Champs" />
      <br />
      <BowlerList />
      <Footer />
    </div>
  );
}

export default App;
