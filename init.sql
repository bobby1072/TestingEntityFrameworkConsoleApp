CREATE TABLE public.accounts(
    id SERIAL PRIMARY KEY,
    account_name text NOT NULL,
    balance decimal NOT NULL,
    CONSTRAINT uq_account UNIQUE(account_name, balance)
);

INSERT INTO
    public.accounts(account_name, balance)
VALUES
    ('Bobby', 5000),
    ('Kat', 8000),
    ('Oli', 100.1);