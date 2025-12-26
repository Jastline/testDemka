using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Diagnostics.Metrics;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using testDemka.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testDemka
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Точка входа и инициализации приложения
            ApplicationConfiguration.Initialize();
            Application.Run(new RegistrationForm());
        }
    }
}

/*
BEGIN;


CREATE TABLE IF NOT EXISTS public.category
(
    id serial NOT NULL,
    category character varying COLLATE pg_catalog."default",
    CONSTRAINT category_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.manufacturer
(
    id serial NOT NULL,
    manufacturer character varying COLLATE pg_catalog."default",
    CONSTRAINT manufacturer_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.orderproduct
(
    id serial NOT NULL,
    count integer,
    orderid integer,
    productarticle character varying(6) COLLATE pg_catalog."default",
    CONSTRAINT orderproduct_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.orders
(
    id serial NOT NULL,
    dateorder date,
    datedelivery date,
    code integer,
    pickuppointid integer,
    userid integer,
    statusid integer,
    CONSTRAINT orders_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.pickuppoint
(
    id serial NOT NULL,
    address character varying COLLATE pg_catalog."default",
    CONSTRAINT pickuppoint_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.product
(
    article character varying(6) COLLATE pg_catalog."default" NOT NULL,
    name character varying COLLATE pg_catalog."default",
    unitofmeasurement character varying COLLATE pg_catalog."default" DEFAULT 'шт.'::character varying,
    cost real,
    discount integer,
    instock integer,
    description character varying COLLATE pg_catalog."default",
    photopath character varying COLLATE pg_catalog."default",
    manufacturerid integer,
    categoryid integer,
    providerid integer,
    CONSTRAINT product_pkey PRIMARY KEY(article)
);

CREATE TABLE IF NOT EXISTS public.provider
(
    id serial NOT NULL,
    provider character varying COLLATE pg_catalog."default",
    CONSTRAINT provider_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.roles
(
    id serial NOT NULL,
    role character varying(255) COLLATE pg_catalog."default",
    CONSTRAINT roles_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.status
(
    id serial NOT NULL,
    status character varying COLLATE pg_catalog."default",
    CONSTRAINT status_pkey PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS public.users
(
    id serial NOT NULL,
    firstname character varying COLLATE pg_catalog."default",
    secondname character varying COLLATE pg_catalog."default",
    lastname character varying COLLATE pg_catalog."default",
    login character varying COLLATE pg_catalog."default",
    password character varying COLLATE pg_catalog."default",
    roleid integer,
    CONSTRAINT users_pkey PRIMARY KEY(id)
);

ALTER TABLE IF EXISTS public.orderproduct
    ADD CONSTRAINT orderproduct_orderid_fkey FOREIGN KEY (orderid)
    REFERENCES public.orders(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.orderproduct
    ADD CONSTRAINT orderproduct_productarticle_fkey FOREIGN KEY (productarticle)
    REFERENCES public.product(article) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.orders
    ADD CONSTRAINT orders_pickuppointid_fkey FOREIGN KEY (pickuppointid)
    REFERENCES public.pickuppoint(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.orders
    ADD CONSTRAINT orders_statusid_fkey FOREIGN KEY (statusid)
    REFERENCES public.status(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.orders
    ADD CONSTRAINT orders_userid_fkey FOREIGN KEY (userid)
    REFERENCES public.users(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.product
    ADD CONSTRAINT product_categoryid_fkey FOREIGN KEY (categoryid)
    REFERENCES public.category(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.product
    ADD CONSTRAINT product_manufacturerid_fkey FOREIGN KEY (manufacturerid)
    REFERENCES public.manufacturer(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.product
    ADD CONSTRAINT product_providerid_fkey FOREIGN KEY (providerid)
    REFERENCES public.provider(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;


ALTER TABLE IF EXISTS public.users
    ADD CONSTRAINT users_roleid_fkey FOREIGN KEY (roleid)
    REFERENCES public.roles(id) MATCH SIMPLE
    ON UPDATE CASCADE
    ON DELETE RESTRICT;

END;
*/