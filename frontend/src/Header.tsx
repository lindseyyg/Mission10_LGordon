function Header(props: any) {
  return (
    <header className="row header navbar navbar-dark bg-dark">
      <h1 className="text-white">{props.title}</h1>
    </header>
  );
}

export default Header;
