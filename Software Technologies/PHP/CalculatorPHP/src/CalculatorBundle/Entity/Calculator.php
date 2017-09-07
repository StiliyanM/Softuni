<?php

namespace CalculatorBundle\Entity;

class Calculator
{
    /**
     * @var float
     */

    private $leftOperand;

    /**
     * @var float
     */

    private $rightOperand;

    /**
     * @var string
     */
    private $operator;

    /**
     * @return float
     */
    public function getLeftOperand()
    {
        return $this->leftOperand;
    }

    /**
     * @param $operand
     * @return $this
     */
    public function setLeftOperand($operand)
    {
        $this->leftOperand = $operand;

        return $this;
    }

    /**
     * @return float
     */
    public function getRightOperand()
    {
        return $this->rightOperand;
    }

    /**
     * @param $operand
     * @return $this
     */
    public function setRightOperand($operand)
    {
        $this->rightOperand = $operand;

        return $this;
    }

    /**
     * @return string
     */
    public function getOperator()
    {
        return $this->operator;
    }

    public  function  setOperator($operator)
    {
        $this->operator = $operator;

        return $this;
    }
}