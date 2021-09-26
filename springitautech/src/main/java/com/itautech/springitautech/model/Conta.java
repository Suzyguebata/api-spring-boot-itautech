package com.itautech.springitautech.model;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

@Entity
@Table(name = "tb_contas")
public class Conta {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int conta_numero;

    @Column(name = "conta_agencia", length = 10, nullable = false)
    private String conta_agencia;
    @Column(name = "conta_tipo", length = 1, nullable = false)
    private String conta_tipo;
    @Column(name = "conta_saldo", nullable = false)
    private double conta_saldo;

    @ManyToOne
    @JoinColumn(name = "cliente_id")
    @JsonIgnoreProperties("contas")
    private Cliente cliente_id;

    /* dúvida?
    @ManyToOne
    @JoinColumn(name = "cliente_nome")
    @JsonIgnoreProperties("conta")
    private Cliente cliente_nome;
    */
    public int getConta_numero() {
        return conta_numero;
    }

    public void setConta_numero(int conta_numero) {
        this.conta_numero = conta_numero;
    }

    public String getConta_agencia() {
        return conta_agencia;
    }

    public void setConta_agencia(String conta_agencia) {
        this.conta_agencia = conta_agencia;
    }

    public String getConta_tipo() {
        return conta_tipo;
    }

    public void setConta_tipo(String conta_tipo) {
        this.conta_tipo = conta_tipo;
    }

    public double getConta_saldo() {
        return conta_saldo;
    }

    public void setConta_saldo(double conta_saldo) {
        this.conta_saldo = conta_saldo;
    }

    public Cliente getCliente_id() {
        return cliente_id;
    }

    public void setCliente_id(Cliente cliente_id) {
        this.cliente_id = cliente_id;
    }

}
