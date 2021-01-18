<?php include("pageHeader.php"); ?>
<?php
$pageName = "Pagadores";
?>
<?php include("breadcrumb.php"); ?>


            <div class="row">
                <div class="col-12 mb-5">
                    <h1><?php echo $pageName ?></h1>  
                    <div>                       
                        <!--Indicadores-->
                        <!--Info-->
                        <a class="mr-lg-2" id="info" href="#">
                            <i class="fa fa-fw fa-info-circle text-dark"></i>
                            <span class="d-lg-none">Total</span>
                            <span class="badge badge-pill badge-dark">1235</span>
                        </a>
                        <a class="mr-lg-2" id="ok" href="#">
                            <i class="fa fa-fw fa-check-circle text-success"></i>
                            <span class="d-lg-none">OK</span>
                            <span class="badge badge-pill badge-success">1235</span>
                        </a>
                        <a class="mr-lg-2" id="Error" href="#">
                            <i class="fa fa-fw fa-exclamation-circle text-danger"></i>
                            <span class="d-lg-none">Com problemas</span>
                            <span class="badge badge-pill badge-danger">1235</span>
                        </a>     
                        <a class="mr-lg-5" id="New" href="#">
                            <i class="fa fa-fw fa-plus-circle text-primary"></i>
                            <span class="text-dark">Novo</span>
                        </a>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-12">
                    <!--Table-->
                    <div class="col-10 mb-5">
                        <table data-toggle="table" data-search="true" data-show-columns="true">
                            <thead>
                                <tr class="tr-class-1">
                                    <th data-field="nome" data-valign="middle">Nome</th>
                                    <th data-field="cnpj">CNPJ</th>
                                    <th data-field="contato">Contato</th>
                                    <th data-field="telefone">Telefone</th>
                                    <th>Ações</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr id="tr-id-1" class="tr-class-1" data-title="Pagadores table" data-object='{"key": "value"}'>
                                    <td id="td-id-1" class="td-class-1"> Pagador 01</td>
                                    <td>000.000.000/0001-01</td>
                                    <td>Jose Silva</td>
                                    <td>(12) 2352-2234</td>
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger"></i></a>
                                    </td>
                                </tr>
                                <tr id="tr-id-2" class="tr-class-2">
                                    <td id="td-id-2" class="td-class-2"> Pagador 02</td>
                                    <td>000.000.000/0002-02</td>
                                    <td>Paulo Santos</td>
                                    <td>(13) 2352-9999</td>
                                     <td>
                                        <a href="#"><i class="fa fa-fw fa-edit"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger"></i></a>
                                    </td>
                                </tr>
                                <tr id="tr-id-3" class="tr-class-3">
                                    <td id="td-id-3" class="td-class-3"> Pagador 03</td>
                                    <td>000.000.000/0003-03</td>
                                    <td>Anna Santana</td>
                                    <td>(13) 2346-9999</td>
                                     <td>
                                        <a href="#"><i class="fa fa-fw fa-edit"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger"></i></a>
                                    </td>
                                </tr>
                                <tr id="tr-id-4" class="tr-class-4">
                                    <td id="td-id-4" class="td-class-4"> Pagador 04</td>
                                    <td>000.000.000/0004-04</td>
                                    <td>João Marcos Luna</td>
                                    <td>(11) 3453-9999</td>
                                     <td>
                                        <a href="#"><i class="fa fa-fw fa-edit"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger"></i></a>
                                    </td>
                                </tr>
                                <tr id="tr-id-5" class="tr-class-5">
                                    <td id="td-id-5" class="td-class-5"> Pagador 05</td>
                                    <td>000.000.000/0004-04</td>
                                    <td>Fernando Albuquerque</td>
                                    <td>(21) 4532-9999</td> 
                                    <td>
                                        <a href="#"><i class="fa fa-fw fa-edit"></i></a>
                                        <a href="#"><i class="fa fa-fw fa-times text-danger"></i></a>
                                    </td>
                                </tr>

                            </tbody>
                        </table>
                    </div>
                    <!--Form-->
                    <div class="col-10 mb-5">
                        <div class="card text-white bg-dark o-hidden h-100">
                            <div class="card-header">
                                <div class="mr-5">
                                    <h4>
                                        <i class="fa fa-fw fa-money"></i>&nbsp; <?php echo $pageName ?>
                                    </h4>
                                </div>
                            </div>
                            <form>
                                <div class="card-body bg-light text-dark">
                                    <div class="row">
                                        <div class="col-md-9">
                                            <label for="nomePagador">Nome</label>
                                            <input type="text" class="form-control" name="nomePagador" id="nomePagador" placeholder="Digite o nome do pagador" />
                                        </div>
                                        <div class="col-md-3">
                                            <label for="cnpjPagador">CNPJ</label>
                                            <input type="text" class="form-control" name="cnpjPagador" id="cnpjPagador" placeholder="Digite o CNPJ do pagador" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-9">
                                            <label for="emailPagador">Email</label>
                                            <input type="email" class="form-control" name="emailPagador" id="emailPagador" placeholder="Digite o email do pagador" />
                                        </div>
                                        <div class="col-md-3">
                                            <label for="telefonePagador">Telefone</label>
                                            <input type="text" class="form-control" name="telefonePagador" id="telefonePagador" placeholder="Digite o telefone do pagador" />
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-9">
                                            <label for="contatoPagador">Contato</label>
                                            <input type="text" class="form-control" name="contatoPagador" id="contatoPagador" placeholder="Digite o nome do contato" />
                                        </div>
                                        <div class="col-md-3">
                                            <label for="contatoCelular">Celular</label>
                                            <input type="text" class="form-control" name="contatoCelular" id="contatoCelular" placeholder="Digite o celular do contato" />
                                        </div>
                                    </div>                                    
                                </div>
                                <div class="card-footer bg-dark pull-right">
                                    <button class="btn btn-success" type="submit">Salvar</button>
                                    <button class="btn btn-danger" type="reset">Cancelar</button>
                                </div>
                            </form>

                        </div>
                    </div>
                </div>    

            </div>
        
<?php include("pageFooter.php"); ?>
